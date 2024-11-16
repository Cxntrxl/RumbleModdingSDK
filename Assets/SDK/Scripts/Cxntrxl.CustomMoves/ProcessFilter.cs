using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[JsonTypeOverride("RUMBLE.MoveSystem.ProcessFilter, RUMBLE.Runtime")]
public class ProcessFilter : System.Object
{
    public int ProcessID;
}
