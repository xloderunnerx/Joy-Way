using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.StateMachine
{
    public abstract class BaseState
    {
        [OdinSerialize] protected BaseStateMachine stateMachine;

        public abstract void Enter();
        public abstract void Update();
        public abstract void DealDamage(int value);
        public abstract void Exit();
    }
}