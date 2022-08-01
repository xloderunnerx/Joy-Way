using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Character.Behaviour
{
    public interface IWeaponDropBehaviour<T, K>
    {
        public void Drop(T baseWeapon, K owner);
    }
}