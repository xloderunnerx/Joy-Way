using Character.Behaviour;
using Core.Interface;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.Component;

namespace Character.Component
{
    public class BaseCharacter : SerializedMonoBehaviour
    {
        [OdinSerialize] private IWeaponPickBehaviour<BaseWeapon, BaseHand> weaponPickBehaviour;
        [OdinSerialize] private IWeaponDropBehaviour<IDropableItem<BaseWeapon, BaseHand>, BaseHand> weaponDropBehaviour;
        [OdinSerialize] private BaseHand leftHand;
        [OdinSerialize] private BaseHand rightHand;

        public BaseHand LeftHand { get => leftHand; set => leftHand = value; }
        public BaseHand RightHand { get => rightHand; set => rightHand = value; }

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                if (LeftHand.BaseWeapon == null)
                    leftHand.BaseWeapon = weaponPickBehaviour.Pick(leftHand);
                else
                    weaponDropBehaviour.Drop(leftHand.BaseWeapon, leftHand);
            if (Input.GetKeyDown(KeyCode.E))
                if (RightHand.BaseWeapon == null)
                    rightHand.BaseWeapon = weaponPickBehaviour.Pick(rightHand);
                else
                    weaponDropBehaviour.Drop(rightHand.BaseWeapon, rightHand);
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawSphere(transform.position + leftHand.transform.localPosition, 0.3f);
            Gizmos.DrawSphere(transform.position + rightHand.transform.localPosition, 0.3f);
        }
    }
}