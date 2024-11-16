using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.PlayAudioModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomPlayAudioModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/PlayAudioModifier", order = 19)]
public class PlayAudioModifier : Modifier
{
    public AudioCall AudioCall;
}
