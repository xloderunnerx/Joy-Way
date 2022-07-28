using Core.GenericVariable;
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
        private BaseScarecrow baseScarecrow;
        private IntVariable healthPoints;
        private int damageBuff;

        public BurningState(BaseScarecrow scarecrow, BaseStateMachine stateMachine, IntVariable healthPoints)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
            this.healthPoints = healthPoints;
            damageBuff = 10;
        }

        public override void DealDamage(int value)
        {
            healthPoints.Variable -= value + damageBuff;
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