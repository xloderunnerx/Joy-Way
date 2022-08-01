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
            sequence = DOTween.Sequence();   
        }

        public override void Enter()
        {
            sequence.Append(baseWeapon.transform.DOMoveY(defaultPosition.y + 0.1f, 5f).SetEase(Ease.Linear));
            sequence.Append(baseWeapon.transform.DOMoveY(defaultPosition.y - 0.1f, 5f).SetEase(Ease.Linear));
            sequence.Append(baseWeapon.transform.DOMoveY(defaultPosition.y, 2.5f).SetEase(Ease.Linear));
            sequence.SetLoops(-1);
        }

        public override void Exit()
        {
            sequence.Kill();
        }

        public override void Update()
        {
            
        }
    }
}