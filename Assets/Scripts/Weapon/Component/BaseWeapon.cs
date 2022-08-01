using Character.Component;
using Core.Interface;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.StateMachine;

namespace Weapon.Component
{
    public class BaseWeapon : SerializedMonoBehaviour, IPickableItem<BaseWeapon, BaseHand>
    {
        [OdinSerialize] private BaseWeaponStateMachine stateMachine;
        private BaseWeaponState floatingState;
        private BaseWeaponState inHandState;
        private Vector3 floatingPosition;

        private void Awake()
        {
            floatingPosition = transform.position;
            InitStateMachine();
        }

        void Start()
        {

        }

        void Update()
        {
            stateMachine.CurrentState.Update();
        }

        private void LateUpdate()
        {
            stateMachine.CurrentState.LateUpdate();
        }

        private void InitStateMachine()
        {
            stateMachine = new BaseWeaponStateMachine();
            floatingState = new FloatingState(stateMachine, this, floatingPosition);
            stateMachine.Init(floatingState);
        }


        public BaseWeapon Pick(BaseHand baseHand)
        {
            inHandState = new InHandState(stateMachine, this, baseHand);
            stateMachine.ChangeState(inHandState);
            return this;
        }
    }
}