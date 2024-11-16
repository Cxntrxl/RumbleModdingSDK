using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.StompStructureModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomStompStructureModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/JointControl/StompStructureModifier", order = 5)]
public class StompStructureModifier : JointControlModifier
{
    public bool AcceptForceMultiplierInput;

    public float AllignSpeed;

    public LayerMask FloorSampleMask;

    public float ForceMultiplyer;

    public State GroundedState;

    public bool MultiplyForceByMass;

    public bool NormalizeInitialForce;

    public PooledVisualEffect StompVFX;
}
