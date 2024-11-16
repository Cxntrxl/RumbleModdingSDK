using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Poses.PoseData, RUMBLE.Runtime")]
public class SerializablePoseData
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

    //[SerializeField]
    public Condition headsetCondition;
    //public Condition HeadsetCondition { get { return headsetCondition; } set { headsetCondition = value; } }

    //[SerializeField]
    public Condition leftControllerCondition;
    //public Condition LeftControllerCondition { get { return leftControllerCondition; } set { leftControllerCondition = value; } }

    //[SerializeField]
    public Condition rightControllerCondition;
    //public Condition RightControllerCondition { get { return rightControllerCondition; } set { rightControllerCondition = value; } }

    //[SerializeField]
    public AnimationClip poseAnimation;
    //public AnimationClip PoseAnimation { get { return poseAnimation; } }

    //[SerializeField]
    public PlayerMeasurement referenceMeasurement;
    //public PlayerMeasurement ReferenceMeasurement { get { return referenceMeasurement; } set { referenceMeasurement = value; } }
}
