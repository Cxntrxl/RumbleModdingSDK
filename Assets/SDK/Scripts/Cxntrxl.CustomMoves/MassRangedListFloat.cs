using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomMassRangedListFloat", menuName = "Cxntrxl.CustomMoves/MassRangedList/MassRangedListFloat", order = 1)]
[JsonTypeOverride("RUMBLE.MoveSystem.MassRangedListFloat, RUMBLE.Runtime")]
public class MassRangedListFloat : MassRangedList<float>
{
}
