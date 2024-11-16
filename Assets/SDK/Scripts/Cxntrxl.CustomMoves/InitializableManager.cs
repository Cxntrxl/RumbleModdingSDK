using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Managers.InitializableManager<T>, RUMBLE.Runtime")]
public class InitializableManager<T> : Singleton<T> where T : BucketMonoBehaviour
{
    [SerializeField]
    private bool isInitialized;
    public bool IsInitialized { get { return isInitialized; } }
}
