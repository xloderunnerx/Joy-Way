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
        [OdinSerialize] private IDisplayBehaviour<GameObject> healthDisplayBehaviour;
        [OdinSerialize] private IntVariable healthPoints;

        private void Awake()
        {
            Dispose();
            healthPoints.OnVariableChanged += UpdateDisplay;
        }

        private void UpdateDisplay(int value) => healthDisplayBehaviour.UpdateDisplay(gameObject);

        private void OnDestroy() => Dispose();

        public void Dispose() => healthPoints.OnVariableChanged -= UpdateDisplay;
    }
}