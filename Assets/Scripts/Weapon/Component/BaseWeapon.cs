using Character.Component;
using Core.Interface;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Behaviour;
using Weapon.SO;
using Weapon.StateMachine;

namespace Weapon.Component
{
    public class BaseWeapon : SerializedMonoBehaviour, IPickableItem<BaseWeapon, BaseHand>, IDropableItem<BaseWeapon, BaseHand>
    {
        [OdinSerialize] private BaseWeaponSettings baseWeaponSettings;
        [OdinSerialize] private GameObject shootingPoint;
        private BaseWeaponStateMachine stateMachine;
        private BaseWeaponState floatingState;
        private BaseWeaponState inHandState;
        private BaseWeaponState shootingState;
        private Vector3 floatingPosition;
        private BaseHand baseHand;

        public BaseWeaponStateMachine StateMachine { get => stateMachine; set => stateMachine = value; }
        public GameObject ShootingPoint { get => shootingPoint; set => shootingPoint = value; }
        public BaseWeaponSettings BaseWeaponSettings { get => baseWeaponSettings; set => baseWeaponSettings = value; }

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
            this.baseHand = baseHand;
            inHandState = new InHandState(stateMachine, this, baseHand);
            stateMachine.ChangeState(inHandState);
            return this;
        }

        public BaseWeapon Drop(BaseHand owner)
        {
            baseHand = null;
            stateMachine.ChangeState(floatingState);
            return this;
        }

        public void StartShooting()
        {
            shootingState = new ShootingState(stateMachine, this, baseHand, baseWeaponSettings);
            stateMachine.ChangeState(shootingState);
        }

        public void StopShooting()
        {
            stateMachine.ChangeState(inHandState);
        }
    }
}