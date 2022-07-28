using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.StateMachine
{
    public abstract class BaseStateMachine
    {
        public BaseState currentState;

        public virtual void InitStateMachine(BaseState state)
        {
            currentState = state;
            currentState.Enter();
        }

        public virtual void ChangeState(BaseState newState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}