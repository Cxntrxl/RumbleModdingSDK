using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.AddForceRailedToPlayerModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomAddForceRailedToPlayerModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/JointControl/AddForceRailedToPlayerModifier", order = 4)]
public class AddForceRailedToPlayerModifier : JointControlModifier
{
    public SerializableVector3 Axis;

    public JointControl.DetachConditions DetachConditions;

    public bool DisableGroundCollisionWhenRailed;

    public bool DisablePIDControllerWhenRailed;

    public AnimationCurve DistanceInverseForceCurve;

    public float Force;

    public ForceMode ForceMode;

    public string ForceVisualEffectPoolName;

    public bool Horizontal;

    public ForceMode InverseForceMode;

    public bool MultiplyForceByMass;

    public Space Space;

    public bool Vertical;
}
