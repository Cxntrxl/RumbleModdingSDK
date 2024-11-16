using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.SetGroundCollisionModidier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomSetGroundCollisionModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/SetGroundCollisionModifier", order = 27)]
public class SetGroundCollisionModifier : Modifier
{
    public bool GroundCollisionActive;
}
