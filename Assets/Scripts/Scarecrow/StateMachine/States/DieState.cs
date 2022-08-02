using Scarecrow.Component;
using Scarecrow.Data;
using Scarecrow.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class DieState : BaseScarecrowState
    {
        private BaseScarecrowData baseScarecrowData;
        private ScarecrowSettings scarecrowSettings;

        public DieState(BaseScarecrow baseScarecrow, BaseScarecrowData baseScarecrowData, ScarecrowSettings scarecrowSettings)
        {
            this.baseScarecrow = baseScarecrow;
            this.baseScarecrowData = baseScarecrowData;
            this.stateMachine = baseScarecrowData.stateMachine;
            this.scarecrowSettings = scarecrowSettings;
        }

        public override void AddBurning(int value)
        {
            
        }

        public override void AddWetness(int value)
        {
            
        }

        public override void Enter()
        {
            GameObject.Destroy(baseScarecrow.gameObject);
        }

        public override void Exit()
        {
            
        }

        public override void Hit(int value)
        {
            
        }

        public override void Update()
        {
            
        }
    }
}