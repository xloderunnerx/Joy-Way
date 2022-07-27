using Core.GenericVariable;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.SO
{
    [CreateAssetMenu(fileName = "ScarecrowSettings", menuName = "SO/Scarecrow/ScarecrowSettings")]
    public class ScarecrowSettings : SerializedScriptableObject
    {
        [OdinSerialize] private IntVariable helathPoints;
    }
}