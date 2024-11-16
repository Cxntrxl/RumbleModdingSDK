using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.ParryModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomParryModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/ParryModifier", order = 16)]
public class ParryModifier : Modifier
{
    public bool ClearPositionVelocity;

    public bool ClearRotationalVelocity;

    public State FrozenState;

    public PooledVisualEffect ParryEffect;

    public State ParryState;

    public float ParryTime;

    public float VelocityBreakParryThreshold;
}
