using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.HoldModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomHoldModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/HoldModifier", order = 10)]
public class HoldModifier : Modifier
{
    public bool ApplyCounterGravityForces;

    public bool DetachIfGroundedStructureUngrounds;

    public float ForcePercentage;

    public State FreeGroundedState;

    public State FreeState;

    public float GroundedForcePercentage;

    public Stack GroundedReleaseResponseStack;

    public State GroundedState;

    public float GroundedVelocityThreshold;

    public float headOffset;

    public string JointControlResourceName;

    public bool multiplyVelocityByMass;

    public InputManager.Hand operatingHand;

    public bool ParentEffect;

    public MassRangedList<float> structureN2List;

    public MassRangedList<float> structureNList;

    public PIDControlModes VelocityControlModes;

    public ForceMode VelocityForceMode;

    public MassRangedList<PIDControllerVector3.Settings> velocityPIDControllerSettingsList;

    public float VelocityThreshold;

    public PooledVisualEffect VisualEffect;
}
