using Core.Behaviour;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.SO
{
    [CreateAssetMenu(fileName = "CharacterControllerSettings", menuName = "SO/Character/CharacterController/CharacterControllerSettings")]
    public class CharacterControllerSettings : SerializedScriptableObject
    {
        [OdinSerialize] private IMovementBehaviour<Rigidbody> movementBehaviour;
        [OdinSerialize] private IRotationBehaviour<Transform> cameraRotationBehaviour;
        [OdinSerialize] private IRotationBehaviour<Transform> characterRotationBehaviour;

        public IMovementBehaviour<Rigidbody> MovementBehaviour { get => movementBehaviour; set => movementBehaviour = value; }
        public IRotationBehaviour<Transform> CameraRotationBehaviour { get => cameraRotationBehaviour; set => cameraRotationBehaviour = value; }
        public IRotationBehaviour<Transform> CharacterRotationBehaviour { get => characterRotationBehaviour; set => characterRotationBehaviour = value; }
    }
}