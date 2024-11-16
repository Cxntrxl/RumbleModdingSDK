using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[JsonTypeOverride("RUMBLE.MoveSystem.SceneBoundObject, RUMBLE.Runtime")]
public class SceneBoundObject : MonoBehaviour
{
    public float boundaryCheckInterval;

    public SerializableVector3 initialPosition;

    public Quaternion initialRotation;

    public NetworkGameObject networkGameObject;

    public UnityEvent onReset;

    public PooledMonoBehaviour pooledObjectReference;

    public float resetCheckTimestamp;

    public bool resetOnDestroyStructure;

    public Rigidbody rigidbody;

    public Structure structure;
}
