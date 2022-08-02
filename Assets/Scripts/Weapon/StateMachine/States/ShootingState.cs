using Character.Component;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Behaviour;
using Weapon.Component;
using Weapon.SO;

namespace Weapon.StateMachine
{
    public class ShootingState : BaseWeaponState
    {
        private BaseWeapon baseWeapon;
        private BaseHand baseHand;
        private BaseWeaponSettings baseWeaponSettings;

        public ShootingState(BaseWeaponStateMachine stateMachine, BaseWeapon baseWeapon, BaseHand baseHand, BaseWeaponSettings baseWeaponSettings)
        {
            this.baseWeaponSettings = GameObject.Instantiate(baseWeaponSettings);
            this.baseHand = baseHand;
            this.baseWeaponStateMachine = stateMachine;
            this.baseWeapon = baseWeapon;
        }
        public override void Enter()
        {
            baseWeaponSettings.ShootBehaviour.StartShoot(baseWeapon);
        }

        public override void Exit()
        {
            baseWeaponSettings.ShootBehaviour.EndShoot(baseWeapon);
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