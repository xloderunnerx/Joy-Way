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
        [OdinSerialize] private IntVariable helathPointsMax;

        public IntVariable HelathPoints { get => helathPoints; set => helathPoints = value; }
        public IntVariable HelathPointsMax { get => helathPointsMax; set => helathPointsMax = value; }
    }
}