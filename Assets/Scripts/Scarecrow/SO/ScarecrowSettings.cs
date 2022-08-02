using Core.GenericVariable;
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
        [OdinSerialize] private IntVariable wetnessMax;

        public IntVariable HealthPointsMax { get => healthPointsMax; set => healthPointsMax = value; }
        public IntVariable BurningDurationDefault { get => burningDurationDefault; set => burningDurationDefault = value; }
        public IntVariable WetnessMax { get => wetnessMax; set => wetnessMax = value; }
    }
}