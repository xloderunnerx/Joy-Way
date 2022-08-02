using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.StateMachine
{
    public class BaseScarecrowStateMachine
    {
        private BaseScarecrowState currentState;

        public BaseScarecrowState CurrentState { get => currentState; set => currentState = value; }

        public virtual void InitStateMachine(BaseScarecrowState state)
        {
            currentState = state;
            currentState.Enter();
        }

        public virtual void ChangeState(BaseScarecrowState newState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}