using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.ProcessableComponent, RUMBLE.Runtime")]
public class ProcessableComponent : MonoBehaviour
{
    public bool Active;

    [SerializeField]
    private State baseState;
    public State BaseState { get { return baseState; } }

    public List<SubState> baseSubStates;

    [SerializeField]
    private Component[] cachedComponents;
    public Component[] CachedComponents { get { return cachedComponents; } }

    [SerializeField]
    private State currentState;
    public State CurrentState { get { return currentState; } }

    [SerializeField]
    private StackConfiguration lastStackConfiguration;
    public StackConfiguration LastStackConfiguration { get { return lastStackConfiguration; } set { lastStackConfiguration = value; } }

    [SerializeField]
    private IProcessor latestInfluencedProcessor;
    public IProcessor LatestInfluencedProcessor { get { return latestInfluencedProcessor; } set {  latestInfluencedProcessor = value; } }

    public delegate void onCollision();

    public delegate void onStateChange();

    public onCollision onCollisionEnter;

    public onCollision onCollisionStay;

    public onStateChange onStateChanged;

    [SerializeField]
    private StackConfiguration previousStackConfiguration;
    public StackConfiguration PreviousStackConfiguration { get { return previousStackConfiguration; } set { previousStackConfiguration = value; } }

    [SerializeField]
    private State previousState;
    public State PreviousState { get { return previousState; } }
}
