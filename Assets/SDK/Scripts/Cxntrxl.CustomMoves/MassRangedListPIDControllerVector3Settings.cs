using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomMassRangedListPIDControllerVector3Settings", menuName = "Cxntrxl.CustomMoves/MassRangedList/MassRangedListPIDControllerVector3Settings", order = 3)]
[JsonTypeOverride("RUMBLE.MoveSystem.MassRangedListPIDControllerVector3Settings, RUMBLE.Runtime")]
public class MassRangedListPIDControllerVector3Settings : MassRangedList<PIDControllerVector3.Settings>
{

}
