using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Utilities.Singleton<T>, BucketheadEntertainment.Plugins")]
public class Singleton<T> : BucketMonoBehaviour where T : BucketMonoBehaviour
{
    public bool dontDestroyOnLoad;

    public bool ignoreErrorWhenDuplicatedInstance;

    [SerializeField]
    private T instance;
    public T Instance { get { return instance; } set { instance = value; } }

    public bool ShouldBeDestroyed;
}
