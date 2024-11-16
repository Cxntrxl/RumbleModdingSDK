using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Utilities.PIDController<T>, RUMBLE.Runtime")]
public class PIDController<T> : System.Object
{
    [SerializeField]
    private PIDControlModes activeControlerModes;
    public PIDControlModes ActiveControlerModes { get { return activeControlerModes; } set { activeControlerModes = value; } }

    [SerializeField]
    private T controlValue;
    public T ControlValue { get { return controlValue; } }

    [SerializeField]
    private T integral;
    public T Integral { get {  return integral; } }

    public T previousError;
}
