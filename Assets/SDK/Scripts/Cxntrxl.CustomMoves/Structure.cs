using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[JsonTypeOverride("RUMBLE.MoveSystem.Structure, RUMBLE.Runtime")]
public class Structure : PooledMonoBehaviour
{
    [SerializeField]
    private JointControl activeJointControl;
    public JointControl ActiveJointControl { get { return activeJointControl; } set { activeJointControl = value; } }

    public StructureDamageVisual baseStructureDamageVisual;

    [SerializeField]
    private int baseStructureTier;
    public int BaseStructureTier { get {  return baseStructureTier; } }

    public LayerMask collisionEventMask;

    public CollisionPresenceConfig[] collisionPresenseConfigs;

    public float collisionPresenceDelay;

    [SerializeField]
    private float collisionPresenceThreshold;
    public float CollisionPresenceThreshold { get { return collisionPresenceThreshold; } }

    public float CurrentAngularSpeed;

    [SerializeField]
    private SerializableVector3 currentAngularVelocity;
    public SerializableVector3 CurrentAngularVelocity { get { return currentAngularVelocity; } }

    public PooledAudioSource currentFrictionAudio;

    public PooledVisualEffect currentFrictionVFX;

    public Coroutine currentShakeRoutine;

    public float CurrentSpeed;

    public int currentStateCount;

    [SerializeField]
    private SerializableVector3 currentVelocity;
    public SerializableVector3 CurrentVelocity { get { return currentVelocity; } }

    public PooledAudioSource currentWhooshAudio;

    public StructureDamageVisual[] damageAnimationVisuals;

    public CollisionPresenceConfig defaultCollisionConfig;

    public Material defaultMaterial;

    [SerializeField]
    private bool doNotRegisterStructure;
    public bool DoNotRegisterStructure { get { return doNotRegisterStructure; } }

    public AnimationCurve frictionAudioPitchCurve;

    public State freeState;

    public Coroutine freezePhysicsCoroutine;

    public AudioCall frictionAudioCall;

    public AnimationCurve frictionAudioVolumeCurve;

    public float frictionFXThreshold;

    public PooledVisualEffect frictionVFX;

    public Timer frictionVFXDelayReturnTimer;

    public float frictionVFXReturnalDelay;

    public State frozenState;

    [SerializeField]
    private StructureFXBehaviour fxDisableFlags;
    public StructureFXBehaviour FxDisableFlags { get { return fxDisableFlags; } set { fxDisableFlags = value; } }

    public State groundedState;

    public float groundVertexColorPaintThreshold;

    public float groundVertexColorWriteRange;

    public float groundVertexColorWriteValue;

    [SerializeField]
    private bool indistructable;
    public bool Indistructable { get { return indistructable; } }

    public bool IsGrounded;

    public bool IsLocal;

    [SerializeField]
    private bool isSceneStructure;
    public bool IsSceneStructure { get { return isSceneStructure; } }

    [SerializeField]
    private bool isSpawning;
    public bool IsSpawning { get { return isSpawning; } set { isSpawning = value; } }

    public bool KillStructureOnCollEnvironment;

    public float lastCollisionPresenceTimestamp;

    public StructureState latestAppliedRemoteState;

    public SerializableVector3 latestAppliedStraightDirection;

    public float maxSmearValue;

    public AudioCall onBecameFreeAudio;

    public PooledVisualEffect onBecameFreeVFX;

    public AudioCall onBecameGroundedAudio;

    public PooledVisualEffect onBecameGroundedVFX;

    public AudioCall onDeathAudio;

    public PlayerHapticsSignal onDeathHapticsSignal;

    public PooledVisualEffect onDeathVFX;

    public UnityEvent onStructureDestroyed;

    public State[] optionalGroundedStates;

    public float originalMass;

    public PhotonView PhotonView;

    public bool PhysicsFrozen;

    public SerializableVector3 previousFramePosition;

    [SerializeField]
    private ProcessableComponent processableComponent;
    public ProcessableComponent Processable { get { return processableComponent; } }

    public StructureState[] remoteStateBuffer;

    public SceneBoundObject sceneBoundObject;

    public SpeedTier[] speedTiers;

    public AudioCall whooshAudioCall;

    public AnimationCurve whooshAudioPitchCurve;

    public float whooshAudioThreshold;

    public AnimationCurve whooshAudioVolumeCurve;

    [JsonTypeOverride("RUMBLE.MoveSystem.Structure+StructureDamageVisual, RUMBLE.Runtime")]
    public class StructureDamageVisual
    {
        public Material Material;

        public Mesh Mesh;
    }

    [System.Flags]
    [JsonTypeOverride("RUMBLE.MoveSystem.Structure+StructureFXBehaviour, RUMBLE.Runtime")]
    public enum StructureFXBehaviour
    {
        None = 0,
        EnvironmentCollisionPresence = 2
    }

    [JsonTypeOverride("RUMBLE.MoveSystem.Structure+SpeedTier, RUMBLE.Runtime")]
    public struct SpeedTier
    {
        public float SpeedEffectMultiplier;

        public int Tier;

        public Vector2 VelocityRange;
    }
}
