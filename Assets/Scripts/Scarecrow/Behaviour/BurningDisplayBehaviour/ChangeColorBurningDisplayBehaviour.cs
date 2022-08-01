using Core.GenericVariable;
using DG.Tweening;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public class ChangeColorBurningDisplayBehaviour : IDisplayBehaviour<Material>
    {
        [OdinSerialize] private IntVariable burningDuration;
        [OdinSerialize] private IntVariable burningDurationDefault;
        public void UpdateDisplay(Material context)
        {
            var burningRatio = (float)((float)burningDuration.Variable / (float)burningDurationDefault.Variable);
            context.DOColor(Color.HSVToRGB(0, burningRatio, 1), 0.25f);
        }
    }
}