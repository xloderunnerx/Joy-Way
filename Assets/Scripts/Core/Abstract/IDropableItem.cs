using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Abstract
{
    public interface IDropableItem<T, K>
    {
        public T Drop(K owner);
    }
}