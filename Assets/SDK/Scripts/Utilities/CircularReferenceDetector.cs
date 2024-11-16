using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CircularReferenceDetector : EditorWindow
{
    UnityEngine.Object itemToCheck = null;

    [MenuItem("RUMBLE Modding SDK/Utils/Circular Reference Detector")]
    public static void ShowWindow()
    {
        CircularReferenceDetector window = EditorWindow.GetWindow<CircularReferenceDetector>();
        window.titleContent = new GUIContent("Circular Reference Detector");
        window.ShowUtility();
    }

    private void OnGUI()
    {
        GUILayout.Label("Circular Reference Detector", EditorStyles.largeLabel);
        itemToCheck = EditorGUILayout.ObjectField("Item to Check", itemToCheck, typeof(UnityEngine.Object), true);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Check"))
        {
            Debug.LogWarning(DetectCircularReference(itemToCheck));
            this.Close();
        }

        if (GUILayout.Button("Cancel"))
        {
            this.Close();
        }
        EditorGUILayout.EndHorizontal();
    }


    private readonly HashSet<object> visitedObjects = new HashSet<object>(new ReferenceEqualityComparer());
    private readonly Stack<string> path = new Stack<string>();
    private int MaxDepth = 1000;

    public string DetectCircularReference(object obj)
    {
        visitedObjects.Clear();
        path.Clear();

        string value = DetectCircularReferenceInternal(obj, "Root", 0);

        if (value == null)
        {
            return "No Circular Reference Detected!";
        }
        else return value;
    }

    private string DetectCircularReferenceInternal(object obj, string currentPath, int depth)
    {
        if (obj == null || depth > MaxDepth)
            return $"Reached max depth at: {currentPath} (type: {obj.GetType().Name}";

        if (obj == null || obj.GetType().IsPrimitive || obj is string)
            return null;

        if (visitedObjects.Contains(obj))
        {
            return $"Circular reference detected at: {currentPath} (type: {obj.GetType().Name})";
        }

        if (obj is ScriptableObject scriptableObject && visitedObjects.Contains(scriptableObject))
        {
            return $"Circular reference detected at: {currentPath} (type: {scriptableObject.GetType().Name})";
        }


        visitedObjects.Add(obj);
        path.Push(currentPath);

        foreach (var field in obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            var fieldValue = field.GetValue(obj);
            if (fieldValue != null)
            {
                var result = DetectCircularReferenceInternal(fieldValue, $"{currentPath}.{field.Name}", depth + 1);
                if (result != null)
                {
                    return result;
                }
            }
        }

        foreach (var property in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if (property.CanRead && property.GetIndexParameters().Length == 0 && property.Name != "SyncRoot")
            {
                var propertyValue = property.GetValue(obj);
                if (propertyValue != null)
                {
                    var result = DetectCircularReferenceInternal(propertyValue, $"{currentPath}.{property.Name}", depth + 1);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
        }

        visitedObjects.Remove(obj);
        return null;
    }
}

public class ReferenceEqualityComparer : IEqualityComparer<object>
{
    public new bool Equals(object x, object y) => ReferenceEquals(x, y);
    public int GetHashCode(object obj) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(obj);
}

