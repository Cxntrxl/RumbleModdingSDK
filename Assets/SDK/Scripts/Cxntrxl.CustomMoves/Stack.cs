using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomStack", menuName = "Cxntrxl.CustomMoves/Stack", order = 1)]
[JsonTypeOverride("RUMBLE.MoveSystem.Stack, RUMBLE.Runtime")]
public class Stack : ScriptableObject
{
    [SerializeField]
    private LayerMask allowedFloorMask;
    public LayerMask AllowedFloorMask { get { return allowedFloorMask; } }

    [SerializeField]
    private MovementType allowedMovementTypes;
    public MovementType AllowedMovementTypes { get { return allowedMovementTypes; } }

    [SerializeField]
    private string cachedName;
    public string CachedName { get { return cachedName; } }

    public bool disableAutoExecutionRemoval;

    public int executionLimitForSameTarget;

    [SerializeField]
    private PoseSet inputPoseSet;
    public PoseSet InputPoseSet { get { return inputPoseSet; } set { inputPoseSet = value; } }

    [JsonTypeOverride("RUMBLE.MoveSystem.Stack+StackTargetLimitResponse, RUMBLE.Runtime")]
    public enum StackTargetLimitResponse
    {
        StopAndReplace,
        DoNothing,
        StopAndDontExecute
    }
    public StackTargetLimitResponse limitResponse;

    [SerializeField]
    private List<Process> processes = new List<Process>();
    public List<Process> Processes { get { return processes; } }

    public List<StackConfiguration> runningExecutions = new List<StackConfiguration>();

    public bool sendOverUsageData;

    [Serializable]
    [JsonTypeOverride("RUMBLE.MoveSystem.Stack+TargetLink, RUMBLE.Runtime")]
    public class TargetLink
    {
        public ProcessLink ProcessLink;
        public TargetingObject TargetObject;
    }

    [SerializeField]
    private List<TargetLink> targetLinks = new List<TargetLink>();
    public List<TargetLink> TargetLinks { get { return targetLinks; } }

    public bool useLimitForSingleTarget;
}

[Flags]
[JsonTypeOverride("RUMBLE.Players.Subsystems.PlayerMovement+MovementType, RUMBLE.Runtime")]
public enum MovementType
{
    None = 0,
    Normal = 1,
    Airborne = 2,
    Slide = 4,
    Knockback = 8,
    AirealKnockback = 16
}