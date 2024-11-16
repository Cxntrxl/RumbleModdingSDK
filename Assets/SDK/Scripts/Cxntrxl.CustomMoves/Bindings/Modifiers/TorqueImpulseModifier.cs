using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.TorqueImpulseModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomTorqueImpulseModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/TorqueImpulseModifier", order = 32)]
public class TorqueImpulseModifier : Modifier
{
    public bool ContinuousForce;

    public ForceMode ForceMode;

    public SerializableVector3 RotationDirection;

    public Space RotationSpace;

    public float TorqueMultiplier;

    public float TotalAngles;
}
