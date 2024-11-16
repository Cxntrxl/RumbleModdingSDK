using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.WaitModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomWaitModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/WaitModifier", order = 33)]
public class WaitModifier : Modifier
{
    public float Time;
}
