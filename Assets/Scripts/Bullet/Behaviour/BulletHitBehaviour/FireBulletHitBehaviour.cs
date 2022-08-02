using Bullet.Component;
using Core.Abstract;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public class FireBulletHitBehaviour : IBulletHitBehaviour
    {
        [OdinSerialize] private int fireValue;
        public void Hit(BaseBullet baseBullet, Collider collider)
        {
            var iBurning = collider.GetComponentInParent<IBurning>();
            if(iBurning != null)
            {
                iBurning.AddBurning(fireValue);
            }
        }
    }
}