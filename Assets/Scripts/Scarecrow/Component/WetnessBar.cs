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
    public class WetnessBar : SerializedMonoBehaviour, IDisposable
    {
        [OdinSerialize] private IDisplayBehaviour<Material> wetnessDisplayBehaviour;
        [OdinSerialize] private IntVariable wetness;
        [OdinSerialize] private Material wetnessDisplayBar;

        private void Awake()
        {
            Dispose();
            wetness.OnVariableChanged += UpdateDisplay;
        }

        private void UpdateDisplay(int value) => wetnessDisplayBehaviour.UpdateDisplay(wetnessDisplayBar);

        private void OnDestroy() => Dispose();

        public void Dispose() => wetness.OnVariableChanged -= UpdateDisplay;
    }
}