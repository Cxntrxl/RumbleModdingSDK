using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.SpawnStructureGroundedModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomSpawnStructureGroundedModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/SpawnStructureGroundedModifier", order = 30)]
public class SpawnStructureGroundedModifier : SpawnStructureModifier
{
    public SerializableVector3 Direction;

    public Space DirectionSpace;

    public float FloorHeightPaintRaidus;

    public float FloorHeightPaintValue;

    public ForceMode ForceMode;

    public State GroundedState;

    public bool IncreaseFloorHeightOnSpawn;

    public string JointControlResourceName;

    public State JointedState;

    public bool KillStructureIfNotSpawnedFully;

    public PlayerHapticsSignal OnSpawnHapticsSignal;

    public float SpawnForceMultiplier;
}
