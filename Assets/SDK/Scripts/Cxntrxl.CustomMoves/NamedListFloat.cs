using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomNamedListFloat", menuName = "Cxntrxl.CustomMoves/NamedLists/NamedListFloat", order = 1)]
[JsonTypeOverride("RUMBLE.MoveSystem.NamedListFloat, RUMBLE.Runtime")]
public class NamedListFloat : NamedList<float>
{
}
