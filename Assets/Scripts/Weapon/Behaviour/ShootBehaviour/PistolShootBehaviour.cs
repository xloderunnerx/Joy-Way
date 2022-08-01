using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;
using Weapon.StateMachine;

namespace Weapon.Behaviour
{
    public class PistolShootBehaviour : IShootBehaviour<BaseWeapon>
    {
        public void EndShoot(BaseWeapon context)
        {
            
        }

        public void StartShoot(BaseWeapon context)
        {
            var baseWeaponSettings = context.BaseWeaponSettings;
            var bulletGameObject = GameObject.Instantiate(baseWeaponSettings.BulletPrefab);
            bulletGameObject.transform.position = context.ShootingPoint.transform.position;
            bulletGameObject.GetComponent<Rigidbody>().AddForce(context.transform.forward * baseWeaponSettings.BulletForceMultiplier, ForceMode.Impulse);
        }
    }
}