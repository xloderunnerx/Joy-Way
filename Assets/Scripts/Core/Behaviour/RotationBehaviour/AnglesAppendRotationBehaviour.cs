using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Behaviour.Rotation
{
    public class AnglesAppendRotationBehaviour : IRotationBehaviour<Transform>
    {
        [OdinSerialize] private float speedH;
        [OdinSerialize] private float speedV;
        [OdinSerialize] private float speedD;

        [OdinSerialize] private bool rotateYaw;
        [OdinSerialize] private bool rotatePitch;
        [OdinSerialize] private bool rotateRoll;

        private float yaw;
        private float pitch;
        private float roll;

        public AnglesAppendRotationBehaviour(float speedH, float speedV, float speedD)
        {
            this.speedH = speedH;
            this.speedV = speedV;
            this.speedD = speedD;
        }

        public void Rotate(Transform context, Vector3 rotation)
        {
            if (rotateYaw)
                yaw += speedH * rotation.x;
            if (rotatePitch)
                pitch -= speedV * rotation.z;
            if (rotateRoll)
                roll += speedD * rotation.y;
            context.transform.eulerAngles = new Vector3(pitch, yaw, roll);
        }
    }
}