using Core.GenericVariable;
using Scarecrow.Behaviour;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Component
{
    public class HealthBar : SerializedMonoBehaviour, IDisposable
    {
        [OdinSerialize] private IHealthDisplayBehaviour<GameObject> healthDisplayBehaviour;
        [OdinSerialize] private IntVariable healthPoints;
        [OdinSerialize] private IntVariable healthPointsMax;

        private void Awake()
        {
            Dispose();
            healthPoints.OnVariableChanged += UpdateDisplay;
        }

        private void UpdateDisplay(int value) => healthDisplayBehaviour.UpdateDisplay(gameObject, value, healthPointsMax.Variable);

        private void OnDestroy() => Dispose();

        public void Dispose() => healthPoints.OnVariableChanged -= UpdateDisplay;
    }
}