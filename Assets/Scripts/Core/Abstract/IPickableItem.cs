using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Abstract
{
    public interface IPickableItem<T, K>
    {
        public T Pick(K owner);
    }
}