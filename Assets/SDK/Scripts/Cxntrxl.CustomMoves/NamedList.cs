using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.NamedList<T>, RUMBLE.Runtime")]
public class NamedList<T> : ScriptableObject
{
    public List<Entry> entries;
    public T type;

    [System.Serializable]
    [JsonTypeOverride("RUMBLE.MoveSystem.NamedList<T>+Entry, RUMBLE.Runtime")]
    public struct Entry
    {
        [SerializeField]
        private string name;
        public string Name { get { return name; } }

        [SerializeField]
        private T value;
        public T Value { get { return value; } }
    }
}
