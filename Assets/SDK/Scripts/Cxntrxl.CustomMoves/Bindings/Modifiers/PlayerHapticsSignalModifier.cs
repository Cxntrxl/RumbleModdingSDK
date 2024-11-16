using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.PlayerHapticsSignalModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomPlayerHapticsSignalModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/PlayerHapticsSignalModifier", order = 22)]
public class PlayerHapticsSignalModifier : Modifier
{
    public PlayerHapticsSignal HapticsSignal;
}
