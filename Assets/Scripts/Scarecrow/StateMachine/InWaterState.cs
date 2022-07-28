using Core.GenericVariable;
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
        private BaseScarecrow baseScarecrow;
        private IntVariable healthPoints;
        private int damageBuff;
        private Material material;

        public InWaterState(BaseScarecrow scarecrow, BaseStateMachine stateMachine, IntVariable healthPoints, Material material)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
            this.healthPoints = healthPoints;
            damageBuff = -10;
            this.material = material;
        }

        public override void DealDamage(int value)
        {
            healthPoints.Variable -= value + damageBuff;
        }

        public override void Enter()
        {
            material.color = Color.blue;
        }

        public override void Exit()
        {
            material.color = Color.gray;
        }

        public override void Update()
        {
            
        }
    }
}