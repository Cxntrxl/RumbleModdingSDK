using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Networking.NetworkState, RUMBLE.Runtime")]
public struct NetworkState 
{
    public SerializableVector3 AngularVelocity;

    public SerializableVector3 Position;

    public Quaternion Rotation;

    public SerializableVector3 Scale;

    public int TimeStamp;

    public SerializableVector3 Velocity;
}
