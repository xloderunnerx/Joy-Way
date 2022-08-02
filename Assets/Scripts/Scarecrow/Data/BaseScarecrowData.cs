using Core.GenericVariable;
using Scarecrow.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scarecrow.Data
{
    [System.Serializable]
    public class BaseScarecrowData
    {
        public Material material;
        public IntVariable healthPoints;
        public IntVariable burningDuration;
        public IntVariable wetness;

        public BaseScarecrowStateMachine stateMachine;
        public BaseScarecrowState dryState;
        public BaseScarecrowState inWaterState;
        public BaseScarecrowState burningState;
    }
}