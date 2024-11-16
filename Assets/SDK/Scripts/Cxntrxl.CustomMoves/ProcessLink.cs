using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[JsonTypeOverride("RUMBLE.MoveSystem.ProcessLink, RUMBLE.Runtime")]
public class ProcessLink : System.Object
{
    [SerializeField]
    private List<ProcessFilter> filters = new List<ProcessFilter>();
    public List<ProcessFilter> Filters { get {  return filters; } }
}
