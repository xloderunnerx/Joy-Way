using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon.StateMachine;

namespace Weapon.Component
{
    public class BaseWeapon : SerializedMonoBehaviour
    {
        [OdinSerialize] private BaseWeaponStateMachine stateMachine;
        private BaseWeaponState floatingState;

        private void Awake()
        {
            InitStateMachine();
        }

        void Start()
        {

        }

        void Update()
        {

        }
        private void InitStateMachine()
        {
            stateMachine = new BaseWeaponStateMachine();
            floatingState = new FloatingState(stateMachine, this, transform.position);
            stateMachine.Init(floatingState);
        }
    }
}