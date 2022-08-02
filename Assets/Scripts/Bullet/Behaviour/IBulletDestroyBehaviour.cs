using Bullet.Component;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Behaviour
{
    public interface IBulletDestroyBehaviour
    {
        public void Destroy(BaseBullet baseBullet);
    }
}