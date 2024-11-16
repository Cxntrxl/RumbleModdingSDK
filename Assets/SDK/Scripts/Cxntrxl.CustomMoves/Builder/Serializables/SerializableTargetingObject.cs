using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.TargetingObject, RUMBLE.Runtime")]
public class SerializableTargetingObject
{
    public bool avoidSpawningStructures;
}
