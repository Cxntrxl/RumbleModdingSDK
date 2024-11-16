using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.ReflectModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomReflectModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/ReflectModifier", order = 25)]
public class ReflectModifier : Modifier
{
    public AudioCall activationSFX;

    public PooledVisualEffect activationVFX;

    public bool ApplyCounterGravityForces;

    public AudioCall endingSFX;

    public PooledVisualEffect endingVFX;

    public float FinalBurstForceMultiplier;

    public float headOffset;

    public float HoldDuration;

    public float HoldForcePercentage;

    public bool multiplyFinalVelocityByMass;

    public bool multiplyHoldVelocityByMass;

    public InputManager.Hand operatingHand;

    public ForceMode PIDControllerForceMode;

    public MassRangedList<float> structureN2List;

    public MassRangedList<float> structureNList;

    public PIDControlModes VelocityControlModes;

    public MassRangedList<PIDControllerVector3.Settings> velocityPIDControllerSettingsList;
}
