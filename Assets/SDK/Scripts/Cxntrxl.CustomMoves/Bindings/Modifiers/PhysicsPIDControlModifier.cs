using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.PhysicsPIDControlModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomPhysicsPIDControlModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/PhysicsPIDControlModifier", order = 17)]
public class PhysicsPIDControlModifier : Modifier
{
    public PIDControlModes AngularVelocityControlModes;

    public MassRangedList<PIDControllerVector3.Settings> angularvelocityPIDControllerSettingsList;

    public bool DetachIfPlayerProcessorIsHit;

    public float ForcePercentage;

    public float MaxDuration;

    public bool multiplyVelocityByMass;

    public bool NormalizeShoulderSpaceLength;

    public bool ParentEffect;

    public float PositionHandShoulderSpaceOffset;

    public SerializableVector3 PositionTargetOffset;

    public SerializableVector3 RotationTargetOffset;

    public ModifierSpace TargetPositionSpace;

    public ModifierSpace TargetRotationSpace;

    public ForceMode TorqueForceMode;

    public float TorquePercentage;

    public bool UseMaxDurationTimer;

    public bool UseVelocityThreshold;

    public PIDControlModes VelocityControlModes;

    public ForceMode VelocityForceModes;

    public MassRangedList<PIDControllerVector3.Settings> velocityPIDControllerSettingsList;

    public float VelocityThreshold;

    public HoldStackUntilVelocityModifier.WaitOption VelocityThresholdOption;

    public PooledVisualEffect VisualEffect;
}
