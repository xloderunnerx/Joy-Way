using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public interface IHealthDisplayBehaviour<T>
    {
        public void UpdateDisplay(T context, int health, int maxHealth);
    }
}