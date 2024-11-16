using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Players.Subsystems.PlayerPhysics, RUMBLE.Runtime")]
public class PlayerPhysics : PlayerControllerSubsystem
{
    [JsonTypeOverride("RUMBLE.Players.Subsystems.PlayerPhysics+RigidbodyTarget, RUMBLE.Runtime")]
    public enum RigidbodyTarget
    {
        PhysicsBody,
        VRBody,
        Both
    }
}
