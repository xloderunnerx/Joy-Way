using Core.GenericVariable;
using DG.Tweening;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public class ChangeColorWetnessDisplayBehaviour : IDisplayBehaviour<Material>
    {
        [OdinSerialize] private IntVariable wetness;
        [OdinSerialize] private IntVariable wetnessMax;
        public void UpdateDisplay(Material context)
        {
            var wetnessRatio = (float)((float)wetness.Variable / (float)wetnessMax.Variable);
            context.DOColor(Color.HSVToRGB(0.5f, wetnessRatio, 1), 0.25f);
        }
    }
}