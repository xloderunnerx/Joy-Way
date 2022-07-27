using Core.GenericVariable;
using Scarecrow.Behaviour;
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
        [OdinSerialize] private IHealthDisplayBehaviour<BaseScarecrow> healthDisplayBehaviour;

        private void Awake()
        {
            scarecrowSettings.HelathPoints.OnVariableChanged += (v) => { healthDisplayBehaviour.UpdateDisplay(this, v, scarecrowSettings.HelathPointsMax.Variable); };
        }
    }
}