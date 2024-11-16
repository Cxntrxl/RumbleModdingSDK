using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.FlipVelocityModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomFlipVelocityModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/FlipVelocityModifier", order = 8)]
public class FlipVelocityModifier : Modifier
{
    public bool FlipToProcessorForward;
}
