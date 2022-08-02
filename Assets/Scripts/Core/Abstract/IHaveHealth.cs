using Core.GenericVariable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Abstract
{
    public interface IHaveHealth
    {
        public IntVariable GetHealth();
    }
}