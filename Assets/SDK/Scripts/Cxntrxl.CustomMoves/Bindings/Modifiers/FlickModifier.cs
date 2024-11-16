using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomFlickModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/FlickModifier", order = 7)]
[JsonTypeOverride("RUMBLE.MoveSystem.FlickModifier, RUMBLE.Runtime")]
public class FlickModifier : Modifier
{
    public PIDControlModes AngularVelocityControlModes;

    public MassRangedList<PIDControllerVector3.Settings> angularVelocityPIDControllerSettingsList;

    public bool ApplyCounterGravityForces;

    public bool DetachOnRange;

    public float DetachRange;

    public float Duration;

    public float headOffset;

    public PIDControlModes holdControlModes;

    public ForceMode holdForceMode;

    public float holdForceScalar;

    public float holdVelocityDetachThreshold;

    public bool multiplyVelocityByMass;

    public bool ParentEffect;

    public MassRangedList<float> structureN2List;

    public MassRangedList<float> structureNList;

    public ForceMode TorqueForceMode;

    public float TorqueMultiplier;

    public MassRangedList<PIDControllerVector3.Settings> velocityPIDControllerSettingsList;

    public PooledVisualEffect VisualEffect;
}
