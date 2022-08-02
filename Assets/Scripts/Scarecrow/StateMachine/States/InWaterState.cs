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
    public class InWaterState : BaseScarecrowState
    {
        private BaseScarecrowData baseScarecrowData;
        private ScarecrowSettings scarecrowSettings;

        public InWaterState(BaseScarecrow baseScarecrow, BaseScarecrowData baseScarecrowData, ScarecrowSettings scarecrowSettings)
        {
            this.baseScarecrow = baseScarecrow;
            this.stateMachine = baseScarecrowData.stateMachine;
            this.baseScarecrowData = baseScarecrowData;
            this.scarecrowSettings = scarecrowSettings;
        }

        public override void AddBurning(int value)
        {
            baseScarecrowData.wetness.Variable -= value;
            var resultWetness = Mathf.Clamp(baseScarecrowData.wetness.Variable - value, 0, scarecrowSettings.WetnessMax.Variable);
            if (resultWetness == 0)
                stateMachine.ChangeState(new DryState(baseScarecrow, baseScarecrowData, scarecrowSettings));
        }

        public override void AddWetness(int value)
        {
            var resultWetness = Mathf.Clamp(baseScarecrowData.wetness.Variable + value, 0, scarecrowSettings.WetnessMax.Variable);
            baseScarecrowData.wetness.Variable = resultWetness;
        }

        public override void Hit(int value)
        {
            baseScarecrowData.healthPoints.Variable -= value - 10;
        }

        public override void Enter()
        {
            baseScarecrowData.material.color = Color.blue;
        }

        public override void Exit()
        {

        }

        public override void Update()
        {
            
        }
    }
}