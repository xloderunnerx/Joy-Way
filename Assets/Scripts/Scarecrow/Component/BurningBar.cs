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
    public class BurningBar : SerializedMonoBehaviour, IDisposable
    {
        [OdinSerialize] private IDisplayBehaviour<Material> burningDisplayBehaviour;
        [OdinSerialize] private IntVariable burningDuration;
        [OdinSerialize] private Material burningDisplayBar;

        private void Awake()
        {
            Dispose();
            burningDuration.OnVariableChanged += UpdateDisplay;
        }

        private void UpdateDisplay(int value) => burningDisplayBehaviour.UpdateDisplay(burningDisplayBar);

        private void OnDestroy() => Dispose();

        public void Dispose() => burningDuration.OnVariableChanged -= UpdateDisplay;
    }
}