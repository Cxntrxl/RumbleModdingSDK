using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[JsonTypeOverride("RUMBLE.Utilities.PIDControllerVector3, RUMBLE.Runtime")]
public class PIDControllerVector3 : PIDController<Vector3>
{
    public SerializableVector3 derivativeGain;

    public SerializableVector3 integralGain;

    public SerializableVector3 proportionalGain;

    [Serializable]
    [JsonTypeOverride("RUMBLE.Utilities.PIDControllerVector3+Settings, RUMBLE.Runtime")]
    public struct Settings
    {
        public SerializableVector3 DerivativeGain;

        public SerializableVector3 IntegralGain;

        public SerializableVector3 ProportionalGain;
    }
}
