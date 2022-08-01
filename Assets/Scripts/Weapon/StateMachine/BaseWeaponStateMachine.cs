using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon.StateMachine
{
    public class BaseWeaponStateMachine
    {
        [OdinSerialize] private BaseWeaponState currentState;

        public virtual void Init(BaseWeaponState baseWeaponState)
        {
            currentState = baseWeaponState;
            currentState.Enter();
        }

        public virtual void ChangeState(BaseWeaponState newState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}