using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Interface
{
    public interface IPickableItem<T, K>
    {
        public T Pick(K owner);
    }
}