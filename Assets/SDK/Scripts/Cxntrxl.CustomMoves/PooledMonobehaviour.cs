using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[JsonTypeOverride("RUMBLE.Pools.PooledMonoBehaviour, RUMBLE.Runtime")]
public class PooledMonoBehaviour : MonoBehaviourPun
{
    public bool attemptNetworkUpdateOnFetchPool;

    public Timer delayedActivationTimer;

    public bool disableOnReturnPool;

    public bool enableOnFetchPool;

    [SerializeField]
    private bool isInPool;
    public bool IsInPool { get { return isInPool; } set { isInPool = value; } }

    [SerializeField]
    private bool isQueuedForSpawn;
    public bool IsQueuedForSpawn { get { return isQueuedForSpawn; } set {  isQueuedForSpawn = value; } }

    [SerializeField]
    private NetworkGameObject networkGameObject;
    public NetworkGameObject NetworkGameObject { get { return networkGameObject; } }

    public bool networkSyncParentOnSpawn;

    [SerializeField]
    private UnityEvent onFetchedFromPool;
    public UnityEvent OnFetchedFromPool { get { return onFetchedFromPool; } }

    [SerializeField]
    private UnityEvent onReturnedToPool;
    public UnityEvent OnReturnedToPool { get { return onReturnedToPool; } }

    [SerializeField]
    private Pool<PooledMonoBehaviour> owner;
    public Pool<PooledMonoBehaviour> Owner { get { return owner; } set { owner = value; } }

    public bool resetOnReturnPool;

    public bool resetParentOnReturnPool;

    [SerializeField]
    private string resourceName;
    public string ResourceName { get { return resourceName; } }

    public float returnToPoolTime;

    public float returnToPoolTimed;

    public Timer returnToPoolTimer;

    public bool supressPoolingMessages;
}
