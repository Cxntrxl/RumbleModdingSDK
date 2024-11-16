using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomAddForcePIDControlModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/AddForcePIDControlModifier", order = 2)]
[JsonTypeOverride("RUMBLE.MoveSystem.AddForcePIDControlModifier, RUMBLE.Runtime")]
public class AddForcePIDControlModifier : Modifier
{
    public PIDControlModes ActiveControlModes;

    public ForceMode ForceMode;

    public float ForcePercentage;

    public MassRangedList<PIDControllerVector3.Settings> massBasedPIDSettings;

    public float MaxDuration;

    public bool MultiplyForceByMass;

    public float OffsetMultiplier;

    public ModifierSpace OffsetSpace;

    public SerializableVector3 TargetOffset;

    public GetTransformObject TransformTarget;

    public bool UseMaxDurationTimer;

    public bool UseVelocityThreshold;

    public float VelocityThreshold;

    public HoldStackUntilVelocityModifier.WaitOption VelocityThresholdOption;
}

[JsonTypeOverride("RUMBLE.Utilities.PIDControlModes, RUMBLE.Runtime")]
public enum PIDControlModes
{
    Proportional = 2,
    Integral = 4,
    // It's misspelled in the source code, don't shoot the messenger.
    Deravative = 8 
}

[JsonTypeOverride("RUMBLE.MoveSystem.ModifierSpace, RUMBLE.Runtime")]
public enum ModifierSpace
{
    World,
    Processor,
    RightHandShoulder,
    LeftHandShoulder
}
