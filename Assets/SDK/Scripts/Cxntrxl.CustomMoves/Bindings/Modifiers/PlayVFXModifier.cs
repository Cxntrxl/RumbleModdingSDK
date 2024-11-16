using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.PlayVFXModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomPlayVFXModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/PlayVFXModifier", order = 24)]
public class PlayVFXModifier : Modifier
{
    public bool AllignToTargetStructureVelocity;

    public Space OffsetSpace;

    public bool ParentToTarget;

    public SerializableVector3 PositionOffset;

    public SerializableVector3 Rotation;

    public Space RotationSpace;

    public bool SetReferenceStructureData;

    public Structure structureReference;

    public bool UseGroundedPosition;

    public bool UseProcessorSpaceForRotation;

    public string VFXPrefabName;

    public bool WaitForPhysicsStep;
}
