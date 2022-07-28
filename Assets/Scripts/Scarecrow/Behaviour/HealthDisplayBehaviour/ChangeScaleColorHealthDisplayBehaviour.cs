using DG.Tweening;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public class ChangeScaleColorHealthDisplayBehaviour : IHealthDisplayBehaviour<GameObject>
    {
        private MeshRenderer meshRenderer;
        private Transform meshTransform;
        private Vector3 defaultScale;
        private Sequence sequence;

        public void UpdateDisplay(GameObject context, int health, int maxHealth)
        {
            meshRenderer = context.GetComponent<MeshRenderer>();
            meshTransform = context.transform;
            if (defaultScale == Vector3.zero)
                defaultScale = meshTransform.localScale;
            sequence.Kill();
            sequence = DOTween.Sequence();

            var value = (float)((float)health / (float)maxHealth);
            sequence.Append(
                meshTransform.DOScale(new Vector3(meshTransform.localScale.x, defaultScale.y * value, meshTransform.localScale.z), 0.05f)
            );
            var newColor = new Color(1 - value, value, 0);
            sequence.Join(
                meshRenderer.material.DOColor(newColor, 0.05f)
            );
        }
    }
}