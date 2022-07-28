using Core.StateMachine;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class InWaterState : BaseState
    {
        [OdinSerialize] private BaseScarecrow baseScarecrow;

        public InWaterState(BaseScarecrow scarecrow, BaseStateMachine stateMachine)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
        }

        public override void Enter()
        {
            Debug.Log("Entering InWaterState.");
        }

        public override void Exit()
        {
            Debug.Log("Exiting InWaterState.");
        }

        public override void Update()
        {
            
        }
    }
}