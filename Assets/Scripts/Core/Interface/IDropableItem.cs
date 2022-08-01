using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Interface
{
    public interface IDropableItem<T, K>
    {
        public T Drop(K owner);
    }
}