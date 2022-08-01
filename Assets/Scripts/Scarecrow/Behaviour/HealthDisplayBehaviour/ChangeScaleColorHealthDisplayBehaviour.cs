using Core.GenericVariable;
using DG.Tweening;
using Scarecrow.Component;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Behaviour
{
    public class ChangeScaleColorHealthDisplayBehaviour : IDisplayBehaviour<GameObject>
    {
        [OdinSerialize] private IntVariable health;
        [OdinSerialize] private IntVariable healthMax;
        private MeshRenderer meshRenderer;
        private Transform meshTransform;
        private Vector3 defaultScale;
        private Sequence sequence;

        public void UpdateDisplay(GameObject context)
        {
            meshRenderer = context.GetComponent<MeshRenderer>();
            meshTransform = context.transform;
            if (defaultScale == Vector3.zero)
                defaultScale = meshTransform.localScale;
            sequence.Kill();
            sequence = DOTween.Sequence();

            var value = (float)((float)health.Variable / (float)healthMax.Variable);
            sequence.Append(
                meshTransform.DOScale(new Vector3(meshTransform.localScale.x, Mathf.Clamp(defaultScale.y * value, 0, defaultScale.y), meshTransform.localScale.z), 0.05f)
            );
            var newColor = new Color(1 - value, value, 0);
            sequence.Join(
                meshRenderer.material.DOColor(newColor, 0.05f)
            );
        }
    }
}