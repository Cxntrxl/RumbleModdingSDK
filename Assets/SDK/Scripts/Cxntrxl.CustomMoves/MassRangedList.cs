using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.MassRangedList<T>, RUMBLE.Runtime")]
public class MassRangedList<T> : ScriptableObject
{
    [Serializable]
    [JsonTypeOverride("RUMBLE.MoveSystem.MassRangedList<T>+Entry, RUMBLE.Runtime")]
    public class Entry
    {
        [SerializeField]
        private Vector2 massRange;
        public Vector2 MassRange { get { return massRange; } }

        [SerializeField]
        private T value;
        public T Value { get { return value; } }
    }

    public List<Entry> entries = new List<Entry>();

    public T type;
}
