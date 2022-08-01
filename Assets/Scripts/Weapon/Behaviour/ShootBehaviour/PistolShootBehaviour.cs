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

        public void StartShoot(BaseWeapon baseWeapon)
        {
            var baseWeaponSettings = baseWeapon.BaseWeaponSettings;
            var bulletGameObject = GameObject.Instantiate(baseWeaponSettings.BulletPrefab);
            bulletGameObject.transform.position = baseWeapon.ShootingPoint.transform.position;
            bulletGameObject.GetComponent<Rigidbody>().AddForce(baseWeapon.transform.forward * baseWeaponSettings.BulletForceMultiplier, ForceMode.Impulse);
        }
    }
}