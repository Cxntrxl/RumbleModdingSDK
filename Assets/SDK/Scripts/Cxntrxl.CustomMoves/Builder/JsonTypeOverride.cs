using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class JsonTypeOverride : Attribute
{
    public string TypeName;

    public JsonTypeOverride(string typeName)
    {
        TypeName = typeName;
    }
}

