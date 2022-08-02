using Character.Component;
using Core.Abstract;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Character.Behaviour
{
    public class FromHandWeaponDropBehaviour : IWeaponDropBehaviour<IDropableItem<BaseWeapon, BaseHand>, BaseHand>
    {
        public void Drop(IDropableItem<BaseWeapon, BaseHand> baseWeapon, BaseHand owner)
        {
            baseWeapon.Drop(owner);
            owner.BaseWeapon = null;
        }
    }
}