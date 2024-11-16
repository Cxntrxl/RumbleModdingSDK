using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.IProcessable, RUMBLE.Runtime")]
public class IProcessable : MonoBehaviour
{
    public bool Active;
}
