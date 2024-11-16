using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[JsonTypeOverride("RUMBLE.Audio.AudioCall, RUMBLE.Runtime")]
public class AudioCall : ScriptableObject
{
    [SerializeField]
    private WeightedClip[] clips;
    public WeightedClip[] Clips { get { return clips; } set { clips = value; } }

    [SerializeField]
    private GeneralAudioSettings generalSettings;
    public GeneralAudioSettings GeneralSettings { get { return generalSettings; } set { generalSettings = value; } }

    [SerializeField]
    private SpatialAudioSettings spatialSettings;
    public SpatialAudioSettings SpatialSettings { get { return spatialSettings; } set { spatialSettings = value; } }

    public struct GeneralAudioSettings
    {
        public Vector2 MinMaxRandomPitch;

        public Vector2 MinMaxRandomVolume;

        public AudioMixerGroup MixerGroup;

        public float Pitch;

        public bool UseRandomPitch;

        public bool UseRandomVolume;

        public float Volume;
    }

    public struct SpatialAudioSettings
    {
        public AudioRolloffMode AudioRollOff;

        public AnimationCurve CustomReverbZoneMixCurve;

        public AnimationCurve CustomRolloffCurve;

        public AnimationCurve CustomSpatialBlendCurve;

        public AnimationCurve CustomSpreadCurve;

        public float DopplerLevel;

        public Vector2 MinMaxDistance;

        public bool ReverbZoneCurveSet;

        public float ReverbZoneMix;

        public float SpatialBlend;

        public bool SpatialCurveSet;

        public float Spread;
    }

    public struct WeightedClip
    {
        public AudioClip Clip;

        public float Weight;
    }
}
