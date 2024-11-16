using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomDoubleStraightExplodeModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/DoubleStraightExplodeModifier", order = 5)]
[JsonTypeOverride("RUMBLE.MoveSystem.DoubleStraightExplodeModifier, RUMBLE.Runtime")]
public class DoubleStraightExplodeModifier : Modifier
{
    public float doubleStraightEvalValue;

    public float doubleStraightExplodeThreshold;

    public Stack explodeStack;
}
