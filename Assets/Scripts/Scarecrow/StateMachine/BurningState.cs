using Core.StateMachine;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class BurningState : BaseState
    {
        [OdinSerialize] private BaseScarecrow baseScarecrow;

        public BurningState(BaseScarecrow scarecrow, BaseStateMachine stateMachine)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
        }

        public override void Enter()
        {
            Debug.Log("Entering BurningState.");
        }

        public override void Exit()
        {
            Debug.Log("Exiting BurningState.");
        }

        public override void Update()
        {
            
        }
    }
}