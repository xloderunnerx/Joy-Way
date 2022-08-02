using Scarecrow.Component;
using Scarecrow.StateMachine;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public abstract class BaseScarecrowState
    {
        [OdinSerialize] protected BaseScarecrowStateMachine stateMachine;
        [OdinSerialize] protected BaseScarecrow baseScarecrow;

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
        public abstract void Hit(int value);
        public abstract void AddWetness(int value);
        public abstract void AddBurning(int value);
    }
}