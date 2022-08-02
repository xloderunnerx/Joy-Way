using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Component
{
    public class ParticleBullet : BaseBullet
    {
        private void OnParticleCollision(GameObject other)
        {
            bulletHitBehaviour.Hit(this, other.GetComponent<Collider>());
        }
    }
}