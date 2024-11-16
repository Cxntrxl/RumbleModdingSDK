using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Physics.JointControl, RUMBLE.Runtime")]
public class JointControl : PooledMonoBehaviour
{
    [SerializeField]
    private Rigidbody attachedBody;
    public Rigidbody AttachedBody { get { return attachedBody; } }

    [System.Flags]
    [JsonTypeOverride("RUMBLE.Physics.JointControl+DetachConditions, RUMBLE.Runtime")]
    public enum DetachConditions
    {
        None = 0,
        StartReached = 1,
        EndReached = 2,
        VelocityThreshold = 4,
        VelocitySignFlip = 8,
        RailOverride = 16,
        Grounded = 32
    }

    public DetachConditions CurrentDetachConditions;

    public DetachConditions detachConditions;

    [SerializeField]
    private bool disableDetachment;
    public bool DisableDetachment { get { return disableDetachment; } set { disableDetachment = value; } }

    public ConfigurableJoint joint;

    public bool logDetachReason;

    public delegate void OnDetached(DetachConditions cond);

    public OnDetached OnDetach;

    public bool passedMovementThreshold;

    public SerializableVector3 referenceVelocity;

    [SerializeField]
    private bool resetAngularMomentumOnDetach;
    public bool ResetAngularMomentumOnDetach { get { return resetAngularMomentumOnDetach; } set { resetAngularMomentumOnDetach = value;} }

    [SerializeField]
    private bool resetPositionalMomentumOnDetach;
    public bool ResetPositionalMomentumOnDetach { get { return resetPositionalMomentumOnDetach; } set { resetAngularMomentumOnDetach = value; } }

    [SerializeField]
    private bool useProjectionOnDetach;
    public bool UseProjectionOnDetach { get { return useProjectionOnDetach; } set { useProjectionOnDetach = value; } }

    public float velocityDetachThreshold;

    public int velocityFlipFrameCountCheck;

    public int velocitySignFlipFrameCount;
}
