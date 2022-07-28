using Core.GenericVariable;
using Core.StateMachine;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class DryState : BaseState
    {
        private BaseScarecrow baseScarecrow;
        private IntVariable healthPoints;

        public DryState(BaseScarecrow scarecrow, BaseStateMachine stateMachine, IntVariable healthPoints)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
            this.healthPoints = healthPoints;
        }

        public override void DealDamage(int value)
        {
            healthPoints.Variable -= value;
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}