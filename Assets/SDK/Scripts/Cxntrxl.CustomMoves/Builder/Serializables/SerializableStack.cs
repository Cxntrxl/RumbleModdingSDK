using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.Stack, RUMBLE.Runtime")]
public class SerializableStack
{
    //[SerializeField]
    public LayerMask allowedFloorMask;
    //public LayerMask AllowedFloorMask { get { return allowedFloorMask; } }

    //[SerializeField]
    public MovementType allowedMovementTypes;
    //public MovementType AllowedMovementTypes { get { return allowedMovementTypes; } }

    //[SerializeField]
    public string cachedName;
    //public string CachedName { get { return cachedName; } }

    public bool disableAutoExecutionRemoval;

    public int executionLimitForSameTarget;

    //[SerializeField]
    public SerializablePoseSet inputPoseSet;
    //public SerializablePoseSet InputPoseSet { get { return inputPoseSet; } set { inputPoseSet = value; } }

    [JsonTypeOverride("RUMBLE.MoveSystem.Stack+StackTargetLimitResponse, RUMBLE.Runtime")]
    public enum StackTargetLimitResponse
    {
        StopAndReplace,
        DoNothing,
        StopAndDontExecute
    }
    public StackTargetLimitResponse limitResponse;

    //[SerializeField]
    public List<SerializableProcess> processes = new List<SerializableProcess>();
    //public List<Process> Processes { get { return processes; } }

    public List<StackConfiguration> runningExecutions = new List<StackConfiguration>();

    public bool sendOverUsageData;

    [Serializable]
    [JsonTypeOverride("RUMBLE.MoveSystem.Stack+TargetLink, RUMBLE.Runtime")]
    public class SerializableTargetLink
    {
        public ProcessLink ProcessLink;
        public SerializableTargetingObject TargetObject;
    }

    //[SerializeField]
    public List<SerializableTargetLink> targetLinks = new List<SerializableTargetLink>();
    //public List<TargetLink> TargetLinks { get { return targetLinks; } }

    public bool useLimitForSingleTarget;
}
