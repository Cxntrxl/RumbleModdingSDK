using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.PlayVFXAtPlayerModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomPlayVFXAtPlayerModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/PlayVFXAtPlayerModifier", order = 23)]
public class PlayVFXAtPlayerModifier : Modifier
{
    public bool parentToPlayer;

    public SerializableVector3 PositionOffset;

    public string VFXPrefabName;
}
