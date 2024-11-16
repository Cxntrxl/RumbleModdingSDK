using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.Process, RUMBLE.Runtime")]
public class SerializableProcess 
{
    //[SerializeField]
    public List<SerializableBinding> bindings = new List<SerializableBinding>();
    //public List<SerializableBinding> Bindings { get { return bindings; } set { bindings = value; } }

    //[SerializeField]
    public int identifier;
    //public int Identifier { get { return identifier; } }

    //[SerializeField]
    public SerializableBinding structureSpawnModifier;
    //public SerializableBinding StructureSpawnModifier { get { return structureSpawnModifier; } set { structureSpawnModifier = value; } }
}
