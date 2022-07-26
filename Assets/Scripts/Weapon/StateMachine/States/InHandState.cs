using Character.Component;
using DG.Tweening;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Weapon.StateMachine
{
    public class InHandState : BaseWeaponState
    {
        private BaseWeapon baseWeapon;
        private BaseHand baseHand;
        private Sequence sequence;

        public InHandState(BaseWeaponStateMachine stateMachine, BaseWeapon baseWeapon, BaseHand baseHand)
        {
            this.baseWeaponStateMachine = stateMachine;
            this.baseWeapon = baseWeapon;
            this.baseHand = baseHand;
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            sequence.Kill();
        }

        public override void LateUpdate()
        {
            
            baseWeapon.transform.position = Vector3.Slerp(baseWeapon.transform.position, baseHand.transform.position, 0.1f);
            baseWeapon.transform.rotation = Quaternion.Slerp(baseWeapon.transform.rotation, baseHand.transform.rotation, 0.1f);
        }

        public override void Update()
        {
            
        }
    }
}