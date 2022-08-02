using Core.GenericVariable;
using Core.Abstract;
using Scarecrow.Behaviour;
using Scarecrow.SO;
using Scarecrow.StateMachine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scarecrow.Data;

namespace Scarecrow.Component
{
    public class BaseScarecrow : SerializedMonoBehaviour, IHitable, IWet, IBurning
    {
        [OdinSerialize] private ScarecrowSettings scarecrowSettings;
        [OdinSerialize] private BaseScarecrowData baseScarecrowData;
        
        private void Awake()
        {
            baseScarecrowData.healthPoints.Variable = scarecrowSettings.HealthPointsMax.Variable;
        }

        private void Start()
        {
            InitStateMachine();
        }

        private void Update()
        {
            baseScarecrowData.stateMachine.CurrentState.Update();
            if (Input.GetKeyDown(KeyCode.Alpha1))
                baseScarecrowData.stateMachine.ChangeState(baseScarecrowData.dryState);
            if (Input.GetKeyDown(KeyCode.Alpha2))
                baseScarecrowData.stateMachine.ChangeState(baseScarecrowData.inWaterState);
            if (Input.GetKeyDown(KeyCode.Alpha3))
                baseScarecrowData.stateMachine.ChangeState(baseScarecrowData.burningState);
        }

        private void InitStateMachine()
        {
            baseScarecrowData.stateMachine = new BaseScarecrowStateMachine();
            baseScarecrowData.dryState = new DryState(this, baseScarecrowData, scarecrowSettings);
            baseScarecrowData.inWaterState = new InWaterState(this, baseScarecrowData, scarecrowSettings);
            baseScarecrowData.burningState = new BurningState(this, baseScarecrowData, scarecrowSettings);
            baseScarecrowData.stateMachine.InitStateMachine(baseScarecrowData.dryState);
        }

        public void Hit(int value) => baseScarecrowData.stateMachine.CurrentState.Hit(value);

        public void AddBurning(int value) => baseScarecrowData.stateMachine.CurrentState.AddBurning(value);

        public void AddWetness(int value) => baseScarecrowData.stateMachine.CurrentState.AddWetness(value);

    }
}