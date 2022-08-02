using Bullet.Behaviour;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Component
{
    public class BaseBullet : SerializedMonoBehaviour
    {
        [OdinSerialize] protected IBulletHitBehaviour bulletHitBehaviour;

        private void OnTriggerEnter(Collider other)
        {
            bulletHitBehaviour.Hit(other);
        }
    }
}