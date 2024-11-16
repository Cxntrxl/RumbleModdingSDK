using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.SpawnStructureNonGroundedModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomSpawnStructureNonGroundedModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/SpawnStructureNonGroundedModifier", order = 31)]
public class SpawnStructureNonGroundedModifier : SpawnStructureModifier
{
    public Space ForceSpace;

    public bool MultiplyForcebyMass;

    public PlayerHapticsSignal OnSpawnHapticsSignal;

    public SerializableVector3 SpawnForce;
}
