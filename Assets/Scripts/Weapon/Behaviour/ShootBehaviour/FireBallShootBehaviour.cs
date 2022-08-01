using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Weapon.Behaviour
{
    public class FireBallShootBehaviour : IShootBehaviour<BaseWeapon>
    {
        [OdinSerialize] GameObject bulletGameObject;

        public void StartShoot(BaseWeapon context)
        {
            var baseWeaponSettings = context.BaseWeaponSettings;
            bulletGameObject = GameObject.Instantiate(baseWeaponSettings.BulletPrefab, context.transform);
            bulletGameObject.transform.position = context.ShootingPoint.transform.position;
            bulletGameObject.GetComponent<ParticleSystem>().Play();
        }

        public void EndShoot(BaseWeapon context)
        {
            bulletGameObject.GetComponent<ParticleSystem>().Stop();
            GameObject.Destroy(bulletGameObject, 5.0f);
        }
    }
}