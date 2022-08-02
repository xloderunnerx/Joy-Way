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
using System;

namespace Scarecrow.Component
{
    public class BaseScarecrow : SerializedMonoBehaviour, IHitable, IWet, IBurning, IDisposable
    {
        [OdinSerialize] private ScarecrowSettings scarecrowSettings;
        [OdinSerialize] private BaseScarecrowData baseScarecrowData;
        
        private void Awake()
        {
            baseScarecrowData.healthPoints.Variable = scarecrowSettings.HealthPointsMax.Variable;
            baseScarecrowData.healthPoints.OnVariableChanged += CheckHealthPoints;
        }

        private void Start()
        {
            InitStateMachine();
        }

        private void Update()
        {
            baseScarecrowData.stateMachine.CurrentState.Update();
        }

        private void InitStateMachine()
        {
            baseScarecrowData.stateMachine = new BaseScarecrowStateMachine();
            var dryState = new DryState(this, baseScarecrowData, scarecrowSettings);
            baseScarecrowData.stateMachine.InitStateMachine(dryState);
        }

        private void CheckHealthPoints(int value)
        {
            if (baseScarecrowData.healthPoints.Variable <= 0)
                baseScarecrowData.stateMachine.ChangeState(new DieState(this, baseScarecrowData, scarecrowSettings));
        }

        public void Hit(int value) => baseScarecrowData.stateMachine.CurrentState.Hit(value);

        public void AddBurning(int value) => baseScarecrowData.stateMachine.CurrentState.AddBurning(value);

        public void AddWetness(int value) => baseScarecrowData.stateMachine.CurrentState.AddWetness(value);

        public void Dispose()
        {
            baseScarecrowData.healthPoints.OnVariableChanged -= CheckHealthPoints;
        }

        private void OnDestroy()
        {
            Dispose();
        }
    }
}