using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

public class IgnoreCircularReferenceResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        JsonProperty property = base.CreateProperty(member, memberSerialization);
        if (property.PropertyName == "SyncRoot" || property.PropertyName == "hideFlags" || property.PropertyName == "m_Script")
        {
            property.ShouldSerialize = _ => false;
        }
        return property;
    }
}

