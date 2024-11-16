using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.AddForceToPlayerModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomAddForceToPlayerModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/AddForceToPlayerModifier", order = 21)]
public class AddForceToPlayerModifier : PlayerModifier
{
    public float AirealMultiplier; // Buckethead spelling moment

    public bool ClearActiveRails;

    public SerializableVector3 Direction;

    public bool FilterOutAdditiveForce;

    public float Force;

    public ForceMode ForceMode;

    public float MaxPercentageFilteredForces;

    public bool MultiplyByTargetMass;

    public bool RequireStructureTargetToExecute;

    public PlayerPhysics.RigidbodyTarget RigidbodyTarget;

    public Space Space;

    public float TargetMassMultiplier;

    public bool UseProcessorTarget;
}
