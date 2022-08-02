using Core.GenericVariable;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Component
{
    public class ScarecrowController : SerializedMonoBehaviour
    {
        [OdinSerialize] private GameObject scareCrowPrefab;
        [OdinSerialize] private IntVariable healthPoints;
        [OdinSerialize] private IntVariable healthPointsMax;
        [OdinSerialize] private Vector3 spawnPosition;
        [OdinSerialize] private Vector3 spawnRotation;

        private GameObject scarecrowGameObject;

        private void Awake()
        {
            scarecrowGameObject = SpawnScarecrow();
        }

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.R))
                return;
            if (scarecrowGameObject == null)
                SpawnScarecrow();
            else
                HealScarecrow();
        }

        public GameObject SpawnScarecrow()
        {
            var scarecrowGameObject = Instantiate(scareCrowPrefab);
            scarecrowGameObject.transform.position = spawnPosition;
            scarecrowGameObject.transform.rotation = Quaternion.Euler(spawnRotation);
            return scarecrowGameObject;
        }

        public void HealScarecrow() => healthPoints.Variable = healthPointsMax.Variable;
    }
}