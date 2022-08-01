using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon.Behaviour
{
    public interface IShootBehaviour<T>
    {
        public void StartShoot(T context);
        public void EndShoot(T context);
    }
}