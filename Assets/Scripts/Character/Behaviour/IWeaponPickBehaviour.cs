using Character.Component;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Character.Behaviour
{
    public interface IWeaponPickBehaviour<T,K>
    {
        public T Pick(K owner);
    }
}