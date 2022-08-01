using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Weapon.StateMachine
{
    public class FloatingState : BaseWeaponState
    {
        private BaseWeapon baseWeapon;
        private Sequence sequence;
        private Vector3 defaultPosition;

        public FloatingState(BaseWeaponStateMachine stateMachine, BaseWeapon baseWeapon, Vector3 defaultPosition)
        {
            this.baseWeapon = baseWeapon;
            this.baseWeaponStateMachine = stateMachine;
            this.defaultPosition = defaultPosition; 
        }

        public override void Enter()
        {
            sequence = DOTween.Sequence();
            sequence.Append(baseWeapon.transform.DOMove(defaultPosition, 0.3f));
        }

        public override void Exit()
        {
            sequence.Kill();
        }

        public override void LateUpdate()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}