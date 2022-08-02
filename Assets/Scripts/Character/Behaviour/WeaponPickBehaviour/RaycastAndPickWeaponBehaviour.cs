using Character.Component;
using Core.Abstract;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Weapon.Component;

namespace Character.Behaviour
{
    public class RaycastAndPickWeaponBehaviour : IWeaponPickBehaviour<BaseWeapon, BaseHand>
    {
        public BaseWeapon Pick(BaseHand baseHand)
        {
            var hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, Mathf.Infinity);
            var weapons = hits
                .Where(h => h.collider.GetComponentInParent<IPickableItem<BaseWeapon, BaseHand>>() != null)
                .Select(h => h.collider.GetComponentInParent<IPickableItem<BaseWeapon, BaseHand>>())
                .ToList();
            if (weapons.Count == 0)
                return null;
            return weapons.FirstOrDefault().Pick(baseHand);
        }
    }
}