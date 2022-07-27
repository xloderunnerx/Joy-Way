using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.GenericVariable
{
    public class BaseGenericVariable<T> : SerializedScriptableObject
    {
        [OdinSerialize] private T variable;

        public Action<T> OnValueChanged;

        public T Variable
        {
            get => variable; set
            {
                variable = value;
                OnValueChanged?.Invoke(variable);
            }
        }
    }
}