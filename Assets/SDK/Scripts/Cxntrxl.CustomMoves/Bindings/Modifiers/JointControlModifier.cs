using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.JointControlModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomJointControlModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/JointControl/JointControlModifier", order = 0)]
public class JointControlModifier : Modifier
{
    public string JointControlResourceName;

    public State JoinedState;
}
