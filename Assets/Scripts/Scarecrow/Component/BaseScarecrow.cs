using Core.GenericVariable;
using Core.StateMachine;
using Scarecrow.Behaviour;
using Scarecrow.SO;
using Scarecrow.StateMachine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Component
{
    public class BaseScarecrow : SerializedMonoBehaviour
    {
        [OdinSerialize] private ScarecrowSettings scarecrowSettings;
        [OdinSerialize] private IntVariable healthPoints;

        private BaseStateMachine stateMachine;
        private DryState dryState;
        private InWaterState inWaterState;
        private BurningState burningState;
        
        private void Awake()
        {
            healthPoints.Variable = scarecrowSettings.HealthPointsMax.Variable;
        }

        private void Start()
        {
            InitStateMachine();
        }

        private void Update()
        {
            stateMachine.CurrentState.Update();
            if (Input.GetKeyDown(KeyCode.Alpha1))
                stateMachine.ChangeState(dryState);
            if (Input.GetKeyDown(KeyCode.Alpha2))
                stateMachine.ChangeState(inWaterState);
            if (Input.GetKeyDown(KeyCode.Alpha3))
                stateMachine.ChangeState(burningState);
            if (Input.GetKeyDown(KeyCode.Alpha4))
                DealDamage(20);
        }

        private void InitStateMachine()
        {
            stateMachine = new ScarecrowStateMachine();
            dryState = new DryState(this, stateMachine, healthPoints);
            inWaterState = new InWaterState(this, stateMachine, healthPoints);
            burningState = new BurningState(this, stateMachine, healthPoints);
            stateMachine.InitStateMachine(dryState);
        }

        public void DealDamage(int damage)
        {
            stateMachine.CurrentState.DealDamage(damage);
        }
    }
}