using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("UnityEngine.Vector3, UnityEngine")]
[System.Serializable]
public struct SerializableVector3
{
    public float x;
    public float y;
    public float z;
}
