using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Pools.PooledAudioSource, RUMBLE.Runtime")]
public class PooledAudioSource : PooledMonoBehaviour
{
    public float audioClipReturnDelay;

    [SerializeField]
    private AudioSource audioSource;
    public AudioSource AudioSource {  get { return audioSource; } }

    public bool defaultLoopAudioSource;

    public bool playOnFetchPool;

    public bool returnOnDonePlaying;
}
