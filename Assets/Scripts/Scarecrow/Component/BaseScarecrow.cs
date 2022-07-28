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

        private BaseStateMachine stateMachine;
        private IdleState idleState;
        private InWaterState inWaterState;
        private BurningState burningState;

        private void Awake()
        {
            
        }

        private void Start()
        {
            InitStateMachine();
        }

        private void Update()
        {
            stateMachine.currentState.Update();
        }

        private void InitStateMachine()
        {
            stateMachine = new ScarecrowStateMachine();
            idleState = new IdleState(this, stateMachine);
            inWaterState = new InWaterState(this, stateMachine);
            burningState = new BurningState(this, stateMachine);
            stateMachine.InitStateMachine(idleState);
        }
    }
}