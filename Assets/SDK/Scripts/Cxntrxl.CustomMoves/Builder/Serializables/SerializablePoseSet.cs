using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Poses.PoseSet, RUMBLE.Runtime")]
public class SerializablePoseSet
{
    [Serializable]
    [JsonTypeOverride("RUMBLE.Poses.PoseSet+PoseConfiguration, RUMBLE.Runtime")]
    public class SerializablePoseConfiguration
    {
        public SerializablePoseData.ComparisonMethod ComparisonMethod;

        public SerializablePoseData Pose;
    }

    //[SerializeField]
    public SerializablePoseConfiguration[] poseConfigurations;
    //public PoseConfiguration[] PoseConfigurations { get { return poseConfigurations; } }

    //[SerializeField]
    public float resetDelay;
    //public float ResetDelay { get { return resetDelay; } }

    //[SerializeField]
    public float timeRestriction;
    //public float TimeRestriction { get { return timeRestriction; } }
}
