using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomPoseSet", menuName = "Cxntrxl.CustomMoves/PoseSet", order = 2)]
[Serializable]
[JsonTypeOverride("RUMBLE.Poses.PoseSet, RUMBLE.Runtime")]
public class PoseSet : ScriptableObject
{
    [Serializable]
    [JsonTypeOverride("RUMBLE.Poses.PoseSet+PoseConfiguration, RUMBLE.Runtime")]
    public class PoseConfiguration
    {
        public PoseData.ComparisonMethod ComparisonMethod;

        public PoseData Pose;
    }

    [SerializeField]
    private PoseConfiguration[] poseConfigurations;
    public PoseConfiguration[] PoseConfigurations { get { return poseConfigurations; } }

    [SerializeField]
    private float resetDelay;
    public float ResetDelay { get { return resetDelay; } }

    [SerializeField]
    private float timeRestriction;
    public float TimeRestriction { get { return timeRestriction; } }
}
