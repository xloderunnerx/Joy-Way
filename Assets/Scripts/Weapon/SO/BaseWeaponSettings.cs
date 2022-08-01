using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Behaviour;
using Weapon.Component;

namespace Weapon.SO
{
    [CreateAssetMenu(fileName = "BaseWeaponSettings", menuName = "SO/Weapon/BaseWeaponSettings")]
    public class BaseWeaponSettings : SerializedScriptableObject
    {
        [OdinSerialize] private IShootBehaviour<BaseWeapon> shootBehaviour;
        [OdinSerialize] private GameObject bulletPrefab;
        [OdinSerialize] private int damage;
        [OdinSerialize] private float bulletForceMultiplier;

        public IShootBehaviour<BaseWeapon> ShootBehaviour { get => shootBehaviour; set => shootBehaviour = value; }
        public int Damage { get => damage; set => damage = value; }
        public GameObject BulletPrefab { get => bulletPrefab; set => bulletPrefab = value; }
        public float BulletForceMultiplier { get => bulletForceMultiplier; set => bulletForceMultiplier = value; }
    }
}