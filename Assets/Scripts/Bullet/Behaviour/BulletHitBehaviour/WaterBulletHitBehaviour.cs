using Core.Abstract;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public class WaterBulletHitBehaviour : IBulletHitBehaviour
    {
        [OdinSerialize] private int waterCount;

        public void Hit(Collider collider)
        {
            var iWet = collider.gameObject.GetComponentInParent<IWet>();
            if (iWet != null)
                iWet.AddWetness(waterCount);
        }
    }
}