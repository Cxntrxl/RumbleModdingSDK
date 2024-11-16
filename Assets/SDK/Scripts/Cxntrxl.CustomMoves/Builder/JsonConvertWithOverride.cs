using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class JsonConvertWithOverride : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var type = value.GetType();
        var typeNameAttribute = type.GetCustomAttribute<JsonTypeOverride>();
        string typeName = typeNameAttribute?.TypeName ?? type.FullName;

        JObject jo = JObject.FromObject(value, serializer);
        jo.AddFirst(new JProperty("$type", typeName));
        jo.WriteTo(writer);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        jo.Remove("$type");
        return jo.ToObject(objectType, serializer);
    }

    public override bool CanConvert(Type objectType)
    {
        return true;
    }
}
