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
    public class BurningState : BaseScarecrowState
    {
        private BaseScarecrowData baseScarecrowData;
        private ScarecrowSettings scarecrowSettings;
        private Coroutine burningRoutine;

        public BurningState(BaseScarecrow baseScarecrow, BaseScarecrowData baseScarecrowData, ScarecrowSettings scarecrowSettings)
        {
            this.stateMachine = baseScarecrowData.stateMachine;
            this.baseScarecrow = baseScarecrow;
            this.baseScarecrowData = baseScarecrowData;
            this.scarecrowSettings = scarecrowSettings;
        }

        public override void AddBurning(int value)
        {
            baseScarecrowData.healthPoints.Variable -= value;
            baseScarecrowData.burningDuration.Variable = scarecrowSettings.BurningDurationDefault.Variable;
        }

        public override void AddWetness(int value)
        {
            baseScarecrowData.wetness.Variable += value;
            baseScarecrowData.burningDuration.Variable = 0;
            stateMachine.ChangeState(new InWaterState(baseScarecrow, baseScarecrowData, scarecrowSettings));
        }

        public override void Hit(int value)
        {
            baseScarecrowData.healthPoints.Variable -= value + 10;
        }

        public override void Enter()
        {
            baseScarecrowData.material.color = Color.red;
            baseScarecrowData.burningDuration.Variable = scarecrowSettings.BurningDurationDefault.Variable;
            burningRoutine = baseScarecrow.StartCoroutine(Burning());
        }

        public override void Exit()
        {
            baseScarecrow.StopCoroutine(burningRoutine);
        }

        public override void Update()
        {

        }

        private IEnumerator Burning()
        {
            for (baseScarecrowData.burningDuration.Variable = scarecrowSettings.BurningDurationDefault.Variable; baseScarecrowData.burningDuration.Variable > 0; baseScarecrowData.burningDuration.Variable--)
            {
                baseScarecrowData.healthPoints.Variable -= 5;
                yield return new WaitForSeconds(1f);
            }
            stateMachine.ChangeState(new DryState(baseScarecrow, baseScarecrowData, scarecrowSettings));
            yield break;
        }
    }
}