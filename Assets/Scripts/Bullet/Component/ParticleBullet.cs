using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Component
{
    public class ParticleBullet : BaseBullet
    {
        private void OnParticleCollision(GameObject other)
        {
            bulletHitBehaviour.Hit(other.GetComponent<Collider>());
        }
    }
}