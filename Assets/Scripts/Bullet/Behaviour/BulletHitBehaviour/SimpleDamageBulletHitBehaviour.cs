using Core.Abstract;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public class SimpleDamageBulletHitBehaviour : IBulletHitBehaviour
    {
        [OdinSerialize] private int damage;

        public void Hit(Collider collider)
        {
            var iHitable = collider.gameObject.GetComponentInParent<IHitable>();
            if (iHitable != null)
                iHitable.Hit(damage);
        }
    }
}