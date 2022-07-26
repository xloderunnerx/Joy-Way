using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Behaviour
{
    public interface IMovementBehaviour<T>
    {
        public void Move(T context, Vector3 movement);
    }
}