using Bullet.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public class TimerBulletDestroyBehaviour : IBulletDestroyBehaviour
    {
        [OdinSerialize] private float timer;
        public void Destroy(BaseBullet baseBullet)
        {
            GameObject.Destroy(baseBullet.gameObject, timer);
        }
    }
}