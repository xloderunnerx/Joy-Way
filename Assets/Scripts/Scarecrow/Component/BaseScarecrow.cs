using Core.GenericVariable;
using Scarecrow.SO;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Component
{
    public class BaseScarecrow : SerializedMonoBehaviour
    {
        [OdinSerialize] private ScarecrowSettings scarecrowSettings;
    }
}