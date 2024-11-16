using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomAddTorqueModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/AddTorqueModifier", order = 3)]
[JsonTypeOverride("RUMBLE.MoveSystem.AddTorqueModifier, RUMBLE.Runtime")]
public class AddTorqueModifier : Modifier
{
    public ForceMode ForceMode;

    public bool MultiplyForceByMass;

    public RotationSpace Space;

    public SerializableVector3 Torque;

    [JsonTypeOverride("RUMBLE.MoveSystem.AddTorqueModifier+RotationSpace, RUMBLE.Runtime")]
    public enum RotationSpace
    {
        Local,
        World,
        ProcessorOrientation
    }
}
