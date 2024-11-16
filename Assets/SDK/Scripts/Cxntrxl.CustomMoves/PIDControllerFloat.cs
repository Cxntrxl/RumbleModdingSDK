using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[JsonTypeOverride("RUMBLE.Utilities.PIDControllerFloat, RUMBLE.Runtime")]
public class PIDControllerFloat : PIDController<float>
{
    public float derivativeGain;

    public float integralGain;

    public float proportionalGian;

    [Serializable]
    [JsonTypeOverride("RUMBLE.Utilities.PIDControllerFloat+Settings, RUMBLE.Runtime")]
    public struct Settings
    {
        public float DerivativeGain;

        public float IntegralGain;

        public float ProportionalGian;
    }
}
