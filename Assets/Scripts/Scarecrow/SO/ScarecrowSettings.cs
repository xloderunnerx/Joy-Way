using Core.GenericVariable;
using Core.StateMachine;
using Scarecrow.Behaviour;
using Scarecrow.Component;
using Scarecrow.StateMachine;
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
        [OdinSerialize] private IntVariable healthPointsMax;
        [OdinSerialize] private IntVariable burningDurationDefault;

        public IntVariable HealthPointsMax { get => healthPointsMax; set => healthPointsMax = value; }
        public IntVariable BurningDurationDefault { get => burningDurationDefault; set => burningDurationDefault = value; }
    }
}