using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.HoldStackUntilVelocityModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomHoldStackUntilVelocityModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/HoldStackUntilVelocityModifier", order = 13)]
public class HoldStackUntilVelocityModifier : Modifier
{
    [JsonTypeOverride("RUMBLE.MoveSystem.HoldStackUntilVelocityModifier+WaitOption, RUMBLE.Runtime")]
    public enum WaitOption
    {
        Below,
        Above
    }

    public float timeOut;

    public float threshold;

    public WaitOption waitOption;
}
