using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CustomSpawnStructureModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/SpawnStructureModifier", order = 29)]
[JsonTypeOverride("RUMBLE.MoveSystem.SpawnStructureModifier, RUMBLE.Runtime")]
public class SpawnStructureModifier : Modifier
{
    public Collider[] aboveGroundColliders;

    public LayerMask AboveGroundSampleMask;

    [System.Flags]
    [JsonTypeOverride("RUMBLE.MoveSystem.SpawnStructureModifier+SpawnStructureFlag, RUMBLE.Runtime")]
    public enum SpawnStructureFlag
    {
        None = 0,
        NoStructures = 1,
        NoGroundedStructures = 2,
        NoEnvironment = 4
    }

    public SpawnStructureFlag AboveGroundSpawnFlags;

    public Collider[] belowGroundColliders;

    public LayerMask BelowGroundSampleMask;

    public SpawnStructureFlag BelowGroundSpawnFlags;

    public bool CanTriggerPlayerKnockupEvents;

    public bool DebugSpawnSampleBox;

    public bool DontSetStackTarget;

    public bool HorizontalOffset;

    public bool OnlyUseYRotation;

    public LayerMask PlayerControllerSampleMask;

    public SerializableVector3 SpawnPositionOffset;

    public SerializableVector3 SpawnRotationOffset;

    public SerializableVector3 SpawnSampleBoxSize;

    public Structure StructurePrefab;

    public string StructurePrefabName;

    public bool UnGroundedOverlappingGroundedStructures;

    public bool UseGroundSample;

    public bool VerticalOffset;
}
