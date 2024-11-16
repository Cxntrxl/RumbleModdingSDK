using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomMassRangedListPIDControllerFloatSettings", menuName = "Cxntrxl.CustomMoves/MassRangedList/MassRangedListPIDControllerFloatSettings", order = 2)]
[JsonTypeOverride("RUMBLE.MoveSystem.MassRangedListPIDControllerFloatSettings, RUMBLE.Runtime")]
public class MassRangedListPIDControllerFloatSettings : MassRangedList<PIDControllerFloat.Settings>
{
    
}
