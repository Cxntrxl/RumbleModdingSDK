using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Networking.NetworkGameObject, RUMBLE.Runtime")]
public class NetworkGameObject : MonoBehaviourPun
{
    public Rigidbody cachedRigidbody;

    public int currentStateCount;

    public bool debugGizmos;

    public bool disableAutoUpdate;

    public double forceNetworkSyncTimestamp;

    public bool instantApplyFirstState;

    [SerializeField]
    private bool interpolationStarted;
    public bool InterpolationStarted { get { return interpolationStarted; } set { interpolationStarted = value; } }

    public NetworkState latestAppliedState;

    public ViewSynchronization networkStateSyncOption;

    public SerializationFlag serializationFlags;

    public NetworkState[] stateBuffer;

    public SerializationFlag stateFlags;

    public bool updatePositionAndRotationInPhysicsLoop;

    public bool updateUsingPhysicsOnly;

    [System.Flags]
    [JsonTypeOverride("RUMBLE.Networking.NetworkGameObject+SerializationFlag, RUMBLE.Runtime")]
    public enum SerializationFlag
    {
        None = 0,
        Position = 1,
        Rotation = 2, 
        Scale = 4,
        Velocity = 8,
        AngularVelocity = 16
    }
}

[JsonTypeOverride("RUMBLE.Networking.ViewSynchronization, RUMBLE.Runtime")]
public enum ViewSynchronization
{
    Off, 
    ReliableDeltaCompressed,
    Unreliable,
    UnreliableOnChange
}
