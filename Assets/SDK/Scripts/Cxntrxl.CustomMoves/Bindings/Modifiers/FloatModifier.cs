using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.FloatModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomFloatModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/FloatModifier", order = 9)]
public class FloatModifier : Modifier
{
    public float Duration;

    public AnimationCurve IntensityOverLifetime;
}
