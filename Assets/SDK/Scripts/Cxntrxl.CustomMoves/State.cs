using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.State, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomState", menuName = "Cxntrxl.CustomMoves/State", order = 5)]
public class State : ScriptableObject
{
    [SerializeField]
    private string stateName;
    public string StateName { get { return stateName; } }

    [SerializeField]
    private List<SubState> subStates = new List<SubState>();
    public List<SubState> SubStates { get { return subStates; } set { subStates = value; } }

    [SerializeField]
    private int tierValue;
    public int TierValue { get {  return tierValue; } }
}
