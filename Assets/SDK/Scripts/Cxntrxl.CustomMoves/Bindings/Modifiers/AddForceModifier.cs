using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomAddForceModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/AddForceModifier", order = 1)]
[JsonTypeOverride("RUMBLE.MoveSystem.AddForceModifier, RUMBLE.Runtime")]
public class AddForceModifier : Modifier
{
    public bool AcceptForceMultiplierInput;

    public float Duration;

    public SerializableVector3 Force;

    public ForceMode ForceMode;

    public Space ForceSpace;

    public PooledVisualEffect ForceVisualEffect;

    public bool HorizontalForce;

    public bool MultiplyForceByMass;

    public NamedListFloat namedListMultipliers;

    public bool VerticalForce;
}
