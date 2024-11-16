using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[JsonTypeOverride("RUMBLE.Pools.PooledVisualEffect, RUMBLE.Runtime")]
public class PooledVisualEffect : PooledMonoBehaviour
{
    public string dustGroundOffsetName;

    [JsonTypeOverride("RUMBLE.Pools.PooledVisualEffect+ActivationType, RUMBLE.Runtime")]
    public enum ActivationType
    {
        InvokeOnceManual,
        LinkedToMultiplayer
    }

    public ActivationType effectActivation;

    public bool isLoopingEffect;

    public bool isPlaying;

    public PlayerController playerThatSpawnedThisEffect;

    public bool playOnFetchPool;

    public bool playShiftstoneUseEffectsOnPlay;

    public bool requireActiveShiftstoneParametersPresentForUseEffects;

    public string requiredShiftstone;

    public bool setGroundOffsetLevel;

    public bool setStructureDataOnNetworkSpawn;

    public bool stopPlayingOnReturnToPool;

    public List<string> temporaryEnabledShiftstoneParameters;

    public VisualEffect visualEffect;
}
