using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomClearVelocityModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/ClearVelocityModifier", order = 4)]
[JsonTypeOverride("RUMBLE.MoveSystem.ClearVelocityModifier, RUMBLE.Runtime")]
public class ClearVelocityModifier : Modifier
{
    public bool ClearPositionVelocity;

    public bool ClearRotationalVelocity;
}
