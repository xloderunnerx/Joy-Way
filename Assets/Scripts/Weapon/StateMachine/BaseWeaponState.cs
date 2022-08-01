using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon.StateMachine
{
    public abstract class BaseWeaponState
    {
        [OdinSerialize] protected BaseWeaponStateMachine baseWeaponStateMachine;
        public abstract void Enter();
        public abstract void Update();
        public abstract void LateUpdate();
        public abstract void Exit();
    }
}