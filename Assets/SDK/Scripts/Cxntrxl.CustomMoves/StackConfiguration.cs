using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[JsonTypeOverride("RUMBLE.MoveSystem.StackConfiguration, RUMBLE.Runtime")]
public class StackConfiguration : System.Object
{
    public Coroutine ActiveCoroutine;

    public short AlternativeProcessorSourceViewID;

    public short CastingPlayerActorNo;

    [SerializeField]
    private Stack executedStack;
    public Stack ExecutedStack { get { return executedStack; } set { executedStack = value; } }

    [SerializeField]
    private bool isRemoteStack;
    public bool IsRemoteStack { get { return isRemoteStack;} }

    public float OfflineTimestamp;

    public Action<Modifier> OnModifierEnded;

    public Action<Modifier> OnModifierStarts;

    public Action OnStackExecutionTerminated;

    public int ProcessIdentifier;

    public IProcessor Processor;

    public SerializableVector3 RemoteInitiatedPosition;

    public Quaternion RemoteInitiatedRotation;

    public IProcessable TargetProcessable;

    public int Timestamp;
}
