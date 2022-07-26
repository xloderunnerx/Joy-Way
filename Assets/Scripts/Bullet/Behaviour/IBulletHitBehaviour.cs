using Bullet.Component;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public interface IBulletHitBehaviour
    {
        public void Hit(BaseBullet baseBullet, Collider collider);
    }
}