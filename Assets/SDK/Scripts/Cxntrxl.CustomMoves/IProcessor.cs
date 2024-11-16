using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[JsonTypeOverride("RUMBLE.MoveSystem.IProcessor, RUMBLE.Runtime")]
public class IProcessor 
{
    public Transform ProcessableTransformData;
}
