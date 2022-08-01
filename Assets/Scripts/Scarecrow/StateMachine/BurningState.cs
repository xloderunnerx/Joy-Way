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
        private IntVariable burningDuration;
        private IntVariable burningDurationDefault;
        private int damageBuff;
        private Material material;
        private Coroutine burningRoutine;

        public BurningState(BaseScarecrow scarecrow, BaseStateMachine stateMachine, IntVariable healthPoints, IntVariable burningDuration, IntVariable burningDurationDefault, Material material)
        {
            this.baseScarecrow = scarecrow;
            this.stateMachine = stateMachine;
            this.healthPoints = healthPoints;
            this.burningDuration = burningDuration;
            this.burningDurationDefault = burningDurationDefault;
            this.material = material;
            damageBuff = 10;
        }

        public override void DealDamage(int value)
        {
            healthPoints.Variable -= value + damageBuff;
        }

        public override void Enter()
        {
            material.color = Color.red;
            burningDuration.Variable = burningDurationDefault.Variable;
            burningRoutine = baseScarecrow.StartCoroutine(Burning());
        }

        public override void Exit()
        {
            baseScarecrow.StopCoroutine(burningRoutine);
            material.color = Color.gray;
        }

        public override void Update()
        {
            
        }

        private IEnumerator Burning()
        {
            for(burningDuration.Variable = burningDurationDefault.Variable; burningDuration.Variable > 0; burningDuration.Variable--)
            {
                healthPoints.Variable -= 5;
                yield return new WaitForSeconds(1f);
            }
            stateMachine.ChangeState(new DryState(baseScarecrow, stateMachine, healthPoints));
            yield break;
        }
    }
}