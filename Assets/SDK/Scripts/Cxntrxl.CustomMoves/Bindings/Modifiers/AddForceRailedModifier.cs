using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.AddForceRailedModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomAddForceRailedModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/JointControl/AddForceRailedModifier", order = 3)]
public class AddForceRailedModifier : JointControlModifier
{
    public SerializableVector3 Axis;

    public JointControl.DetachConditions DetachConditions;

    public bool DisableGroundCollisionWhenRailed;

    public AnimationCurve DistanceInverseForceCurve;

    public bool EnableGroundedWhenDone;

    public float Force;

    public float ForceDuration;

    public ForceMode ForceMode;

    public State GroundedState;

    public bool Horizontal;

    public ForceMode InverseForceMode;

    public bool MultiplyForceByMass;

    public Space Space;

    public bool Vertical;
}
