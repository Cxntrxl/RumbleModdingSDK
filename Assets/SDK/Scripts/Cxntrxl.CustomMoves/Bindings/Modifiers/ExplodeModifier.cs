using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomExplodeModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/ExplodeModifier", order = 6)]
[JsonTypeOverride("RUMBLE.MoveSystem.ExplodeModifier, RUMBLE.Runtime")]
public class ExplodeModifier : Modifier
{
    public PlayerHapticsSignal activationHaptics;

    public AudioCall activationSFX;

    public float baseExplosionForce;

    public float baseExplosionRadius;

    public float baseGroundedExplosionForce;

    public PlayerHapticsSignal endingHaptics;

    public AudioCall endingSFX;

    public PooledVisualEffect ExplodeActivationVFX;

    public PooledVisualEffect ExplodeEndVFX;

    public PooledVisualEffect ExplodeStatusVFX;

    public State FreeState;

    public AudioCall statusSFX;
}
