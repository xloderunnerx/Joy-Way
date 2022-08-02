using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Character.Component
{
    public class BaseHand : SerializedMonoBehaviour
    {
        [OdinSerialize] private BaseCharacter baseCharacter;
        [OdinSerialize] private BaseWeapon baseWeapon;

        public BaseWeapon BaseWeapon { get => baseWeapon; set => baseWeapon = value; }

        private void Awake()
        {
            baseCharacter = GetComponentInParent<BaseCharacter>();
        }
    }
}