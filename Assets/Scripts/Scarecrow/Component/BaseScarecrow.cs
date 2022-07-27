using Core.GenericVariable;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Component
{
    public class BaseScarecrow : SerializedMonoBehaviour
    {
        [OdinSerialize] private IntVariable healthPoints;
    }
}