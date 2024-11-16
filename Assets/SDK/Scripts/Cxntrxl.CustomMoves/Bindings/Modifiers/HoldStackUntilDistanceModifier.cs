using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.HoldStackUntillDistanceModifier, RUMBLE.Runtime")]
// ^^ I cried for so long trying to work out why this wasn't deserializing, it's got a double L in the source code >:(
[CreateAssetMenu(fileName = "CustomHoldStackUntilDistanceModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/HoldStackUntilDistanceModifier", order = 12)]
public class HoldStackUntilDistanceModifier : Modifier
{
    [JsonTypeOverride("RUMBLE.MoveSystem.HoldStackUntillDistanceModifier+ComparisonType, RUMBLE.Runtime")]
    public enum ComparisonType
    {
        HigherOrEqual,
        LowerOrEqual
    }

    public ComparisonType Comparison;

    public float Distance;

    public SerializableVector3 Offset;

    public Space OffsetSpace;

    public float Timeout;

    public GetTransformObject TransformTarget;
}
