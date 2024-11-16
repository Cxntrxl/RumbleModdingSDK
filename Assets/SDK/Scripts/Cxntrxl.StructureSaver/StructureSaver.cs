using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;
using System.IO;

public class StructureSaver
{
    static void SaveToFile(string fileName)
    {
        StructureSaveData data = new StructureSaveData();
        data.structures = new();

        foreach (PlaceholderStructure s in GameObject.FindObjectsOfType<PlaceholderStructure>())
        {
            StructureData sData = new();
            switch (s.type)
            {
                case StructureType.disc:
                    sData.structureType = "disc";
                    break;
                case StructureType.pillar:
                    sData.structureType = "pillar";
                    break;
                case StructureType.ball:
                    sData.structureType = "ball";
                    break;
                case StructureType.cube:
                    sData.structureType = "cube";
                    break;
                case StructureType.wall:
                    sData.structureType = "wall";
                    break;
                default:
                    sData.structureType = "unknown";
                    break;
            }

            switch (s.state)
            {
                case StructureState.State:
                    sData.structureState = "State";
                    break;
                case StructureState.StableGrounded:
                    sData.structureState = "StableGrounded";
                    break;
                case StructureState.FreeGrounded:
                    sData.structureState = "FreeGrounded";
                    break;
                case StructureState.Float:
                    sData.structureState = "Float";
                    break;
                case StructureState.Frozen:
                    sData.structureState = "Frozen";
                    break;
                case StructureState.Free:
                    sData.structureState = "Free";
                    break;
                default:
                    sData.structureState = "State";
                    break;
            }

            sData.posX = s.transform.position.x;
            sData.posY = s.transform.position.y;
            sData.posZ = s.transform.position.z;
            sData.rotX = s.transform.rotation.eulerAngles.x;
            sData.rotY = s.transform.rotation.eulerAngles.y;
            sData.rotZ = s.transform.rotation.eulerAngles.z;
            
            data.structures.Add(sData);
        }

        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        string json = JsonConvert.SerializeObject(data);
        using (StreamWriter writer = new StreamWriter(Application.streamingAssetsPath  + $"/{fileName}.RUMBLE"))
        {
            writer.Write(json);
            writer.Dispose();
            writer.Close();
        }
    }

    public struct StructureSaveData
    {
        public List<StructureData> structures;
    }

    public struct StructureData
    {
        public string structureType;

        public string structureState;

        public float posX;
        public float posY;
        public float posZ;

        public float rotX;
        public float rotY;
        public float rotZ;
    }

    public class CreateSaveFile : EditorWindow
    {
        string fileName = "MySavedStructures";

        [MenuItem("RUMBLE Modding SDK/StructureSaver/Save Scene Structures to JSON")]
        public static void ShowWindow()
        {
            CreateSaveFile window = EditorWindow.GetWindow<CreateSaveFile>();
            window.titleContent = new GUIContent("Save Structures");
            window.ShowUtility();
        }

        private void OnGUI()
        {
            GUILayout.Label("Save Structure Layout", EditorStyles.largeLabel);
            fileName = EditorGUILayout.TextField("Save File Name", fileName);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Save"))
            {
                StructureSaver.SaveToFile(fileName);
                this.Close();
            }

            if (GUILayout.Button("Cancel"))
            {
                this.Close();
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}
