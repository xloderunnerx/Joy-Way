using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public interface IDisplayBehaviour<T>
    {
        public void UpdateDisplay(T context);
    }
}