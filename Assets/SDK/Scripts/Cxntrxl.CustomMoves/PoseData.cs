using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomPoseData", menuName = "Cxntrxl.CustomMoves/PoseData", order = 3)]
[JsonTypeOverride("RUMBLE.Poses.PoseData, RUMBLE.Runtime")]
public class PoseData : ScriptableObject
{
    [Serializable]
    [JsonTypeOverride("RUMBLE.Poses.PoseData+Condition, RUMBLE.Runtime")]
    public struct Condition
    {
        public Pose DesiredPose;
        public float PositionThreshold;
        public float RotationThreshold;
    }

    [Flags]
    [JsonTypeOverride("RUMBLE.Poses.PoseData+ComparisonMethod, RUMBLE.Runtime")]
    public enum ComparisonMethod
    {
        Normal = 1,
        Mirrored = 2,
        Any = 3
    }

    [SerializeField]
    private Condition headsetCondition;
    public Condition HeadsetCondition { get { return headsetCondition; } set { headsetCondition = value; } }

    [SerializeField]
    private Condition leftControllerCondition;
    public Condition LeftControllerCondition { get { return leftControllerCondition; } set { leftControllerCondition = value;} }

    [SerializeField]
    private Condition rightControllerCondition;
    public Condition RightControllerCondition { get { return rightControllerCondition; } set {  rightControllerCondition = value; } }

    [SerializeField]
    private AnimationClip poseAnimation;
    public AnimationClip PoseAnimation { get { return poseAnimation; } }

    [SerializeField]
    private PlayerMeasurement referenceMeasurement;
    public PlayerMeasurement ReferenceMeasurement { get {  return referenceMeasurement; } set {  referenceMeasurement = value; } }
}

[JsonTypeOverride("RUMBLE.Players.Scaling.PlayerMeasurement, RUMBLE.Runtime")]
public struct PlayerMeasurement
{
    public float ArmSpan;
    public float Length;
}