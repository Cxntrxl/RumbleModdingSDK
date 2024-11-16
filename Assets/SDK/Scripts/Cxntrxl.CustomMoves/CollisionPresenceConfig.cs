using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Players.Presence.CollisionPresenceConfig, RUMBLE.Runtime")]
public struct CollisionPresenceConfig
{
    public AudioCall AudioCall;

    [JsonTypeOverride("RUMBLE.Players.Presence.CollisionPresenceConfig+ComparisonMethod, RUMBLE.Runtime")]
    public enum ComparisonMethod
    {
        Tag,
        Layer
    }

    public ComparisonMethod Comparison;

    public PlayerHapticsSignal HapticsSignal;

    public int IdentifierLayer;

    public string IdentifierTag;

    public PooledVisualEffect VFX;
}
