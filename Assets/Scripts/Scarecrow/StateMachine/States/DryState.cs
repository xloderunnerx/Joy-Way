using Core.GenericVariable;
using Scarecrow.Component;
using Scarecrow.Data;
using Scarecrow.SO;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class DryState : BaseScarecrowState
    {
        private BaseScarecrowData baseScarecrowData;
        private ScarecrowSettings scarecrowSettings;

        public DryState(BaseScarecrow baseScarecrow, BaseScarecrowData baseScarecrowData, ScarecrowSettings scarecrowSettings)
        {
            this.baseScarecrow = baseScarecrow;
            this.stateMachine = baseScarecrowData.stateMachine;
            this.baseScarecrowData = baseScarecrowData;
            this.scarecrowSettings = scarecrowSettings;
        }

        public override void AddBurning(int value)
        {
            stateMachine.ChangeState(new BurningState(baseScarecrow, baseScarecrowData, scarecrowSettings));
        }

        public override void AddWetness(int value)
        {
            baseScarecrowData.wetness.Variable += value;
            stateMachine.ChangeState(new InWaterState(baseScarecrow, baseScarecrowData, scarecrowSettings));
        }

        public override void Hit(int value)
        {
            baseScarecrowData.healthPoints.Variable -= value;
        }

        public override void Enter()
        {
            baseScarecrowData.material.color = Color.white;
            baseScarecrowData.wetness.Variable = 0;
            baseScarecrowData.burningDuration.Variable = 0;
        }

        public override void Exit()
        {
        }

        public override void Update()
        {
            
        }
    }
}