using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Weapon.Behaviour
{
    public class FireBallShootBehaviour : IShootBehaviour<BaseWeapon>
    {
        public void EndShoot(BaseWeapon context)
        {
            throw new System.NotImplementedException();
        }

        public void StartShoot(BaseWeapon context)
        {
            throw new System.NotImplementedException();
        }
    }
}