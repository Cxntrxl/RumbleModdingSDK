using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Input.InputManager, RUMBLE.Runtime")]
public class InputManager : InitializableManager<InputManager>
{
    [JsonTypeOverride("RUMBLE.Input.InputManager+Hand, RUMBLE.Runtime")]
    [System.Flags]
    public enum Hand
    {
        Left = 1,
        Right = 2
    }
}
