using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[JsonTypeOverride("RUMBLE.MoveSystem.Process, RUMBLE.Runtime")]
public class Process : System.Object
{
    [SerializeField]
    private List<Binding> bindings = new List<Binding>();
    public List<Binding> Bindings { get { return bindings; } set { bindings = value; } }

    [SerializeField]
    private int identifier;
    public int Identifier { get { return identifier; } }

    [SerializeField]
    private Binding structureSpawnModifier;
    public Binding StructureSpawnModifier { get {  return structureSpawnModifier; } set {  structureSpawnModifier = value; } }

    static Process()
    {

    }
}
