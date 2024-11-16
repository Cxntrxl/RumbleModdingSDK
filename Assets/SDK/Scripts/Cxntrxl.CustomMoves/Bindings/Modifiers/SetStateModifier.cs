using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.SetStateModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomSetStateModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/SetStateModifier", order = 28)]
public class SetStateModifier : Modifier
{
    public bool ApplyInstant;

    public State StateToSet;
}
