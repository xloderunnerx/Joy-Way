using Core.StateMachine;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class IdleState : BaseState
    {
        [OdinSerialize] private BaseScarecrow baseScarecrow;

        public IdleState(BaseScarecrow scarecrow, BaseStateMachine stateMachine)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
        }

        public override void Enter()
        {
            Debug.Log("Entering IdeleState.");
        }

        public override void Exit()
        {
            Debug.Log("Exiting IdeleState.");
        }

        public override void Update()
        {
            
        }
    }
}