using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.AddForcePlanarModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomAddForcePlanarModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/JointControl/AddForcePlanarModifier", order = 2)]
public class AddForcePlanarModifier : JointControlModifier
{
    public bool AcceptForceMultiplierInput;

    public Vector2 AlternativeModifierIndexing;

    public JointControl.DetachConditions DetachConditions;

    public bool DisableGroundCollisionWhenRailed;

    public AnimationCurve DistanceInverseForceCurve;

    public bool EnableGroundedWhenDone;

    public SerializableVector3 Force;

    public float ForceDuration;

    public ForceMode ForceMode;

    public Space ForceSpace;

    public PooledVisualEffect ForceVisualsEffect;

    public State FreeState;

    public State GroundedState;

    public bool Horizontal;

    public ForceMode InverseForceMode;

    public bool MultiplyForceByMass;

    public Space PlaneSpace;

    public SerializableVector3 PlaneUpAxis;

    public bool UseAltModifierIfNotGrounded;

    public bool Vertical;
}
