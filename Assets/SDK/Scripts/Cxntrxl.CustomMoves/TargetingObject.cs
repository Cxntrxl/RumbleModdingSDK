using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomTargetingObject", menuName = "Cxntrxl.CustomMoves/TargetingObject", order = 4)]
[JsonTypeOverride("RUMBLE.MoveSystem.TargetingObject, RUMBLE.Runtime")]
public class TargetingObject : ScriptableObject
{
    public bool avoidSpawningStructures;
}
