using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.GroundedPhysicsPIDControlModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomGroundedPhysicsPIDControlModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/GroundedPhysicsPIDControlModifier", order = 18)]
public class GroundedPhysicsPIDControlModifier : PhysicsPIDControlModifier
{
    public State FreeState;

    public State GroundedState;

    public string JointControlResourceName;

    public State JointedState;
}
