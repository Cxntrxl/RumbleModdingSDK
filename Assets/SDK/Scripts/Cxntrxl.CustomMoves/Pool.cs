using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Pools.Pool, RUMBLE.Runtime")]
public class Pool<T> : System.Object where T : MonoBehaviour
{
    public List<T> pooledObjects = new List<T>();

    [SerializeField]
    private T poolItem;
    public T PoolItem { get { return poolItem; } }

    [SerializeField]
    private Transform poolParent;
    public Transform PoolParent { get { return poolParent; } }

    public int Size;
}
