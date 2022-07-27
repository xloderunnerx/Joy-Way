using DG.Tweening;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public class ChangeScaleColorHealthDisplayBehaviour : IHealthDisplayBehaviour<BaseScarecrow>
    {
        [OdinSerialize] private MeshRenderer meshRenderer;
        [OdinSerialize] private Transform meshTransform;
        private Vector3 defaultScale;

        public void UpdateDisplay(BaseScarecrow context, int health, int maxHealth)
        {
            if (defaultScale == Vector3.zero)
                defaultScale = meshTransform.localScale;
            DOTween.KillAll();
            var sequence = DOTween.Sequence();
            var value = (float)((float)health / (float)maxHealth);
            sequence.Append(
            meshTransform.DOScale(new Vector3(meshTransform.localScale.x, defaultScale.y * value, meshTransform.localScale.z), 0.05f)
            );
            var newColor = new Color(meshRenderer.material.color.r, value, 0);
            sequence.Join(
                meshRenderer.material.DOColor(newColor, 0.05f)
            );
        }
    }
}