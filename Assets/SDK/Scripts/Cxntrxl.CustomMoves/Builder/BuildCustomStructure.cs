using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BuildCustomStructure : EditorWindow
{
    string fileName = "MyCustomMove";
    Object itemToBuild = null;

    [MenuItem("RUMBLE Modding SDK/CustomMoves/Build Custom Move")]
    public static void ShowWindow()
    {
        BuildCustomStructure window = EditorWindow.GetWindow<BuildCustomStructure>();
        window.titleContent = new GUIContent("Build Custom Move");
        window.ShowUtility();
    }

    private void OnGUI()
    {
        GUILayout.Label("Build Custom Move", EditorStyles.largeLabel);
        fileName = EditorGUILayout.TextField("Move File Name", fileName);

        itemToBuild = EditorGUILayout.ObjectField("Stack To Build", itemToBuild, typeof(Stack), true);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Build"))
        {
            BuildCustomStructure.SaveToFile(fileName, (Stack)itemToBuild);
            this.Close();
        }

        if (GUILayout.Button("Cancel"))
        {
            this.Close();
        }
        EditorGUILayout.EndHorizontal();
    }

    static void SaveToFile(string fileName, Stack move)
    {
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        SerializableStack sMove = ConvertStackToSerializable(move);

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            Converters = new List<JsonConverter> { new JsonConvertWithOverride() }
        };

        string json = JsonConvert.SerializeObject(move, settings);
        using (StreamWriter writer = new StreamWriter(Application.streamingAssetsPath + $"/{fileName}.RUMBLE"))
        {
            writer.Write(json);
            writer.Dispose();
            writer.Close();
        }
    }

    static SerializableStack ConvertStackToSerializable(Stack move)
    {
        List<SerializablePoseSet.SerializablePoseConfiguration> poseConfigurations = new();
        foreach (PoseSet.PoseConfiguration poseConfig in move.InputPoseSet.PoseConfigurations)
        {
            poseConfigurations.Add(new()
            {
                ComparisonMethod = (SerializablePoseData.ComparisonMethod)(int)poseConfig.ComparisonMethod,
                Pose = new()
                {
                    headsetCondition = new()
                    {
                        DesiredPose = poseConfig.Pose.HeadsetCondition.DesiredPose,
                        PositionThreshold = poseConfig.Pose.HeadsetCondition.PositionThreshold,
                        RotationThreshold = poseConfig.Pose.HeadsetCondition.RotationThreshold
                    },
                    leftControllerCondition = new()
                    {
                        DesiredPose = poseConfig.Pose.LeftControllerCondition.DesiredPose,
                        PositionThreshold = poseConfig.Pose.LeftControllerCondition.PositionThreshold,
                        RotationThreshold = poseConfig.Pose.LeftControllerCondition.RotationThreshold
                    },
                    rightControllerCondition = new()
                    {
                        DesiredPose = poseConfig.Pose.RightControllerCondition.DesiredPose,
                        PositionThreshold = poseConfig.Pose.RightControllerCondition.PositionThreshold,
                        RotationThreshold = poseConfig.Pose.RightControllerCondition.RotationThreshold
                    },
                    poseAnimation = poseConfig.Pose.PoseAnimation,
                    referenceMeasurement = poseConfig.Pose.ReferenceMeasurement
                }
            });
        }


        SerializableStack sMove = new()
        {
            allowedFloorMask = move.AllowedFloorMask,
            allowedMovementTypes = move.AllowedMovementTypes,
            cachedName = move.CachedName,
            disableAutoExecutionRemoval = move.disableAutoExecutionRemoval,
            executionLimitForSameTarget = move.executionLimitForSameTarget,
            inputPoseSet = new()
            {
                poseConfigurations = poseConfigurations.ToArray(),
                resetDelay = move.InputPoseSet.ResetDelay,
                timeRestriction = move.InputPoseSet.TimeRestriction
            },
            //processes = move.Processes, FIX
            sendOverUsageData = move.sendOverUsageData,
            // targetLinks = move.TargetLinks, FIX
            useLimitForSingleTarget = move.useLimitForSingleTarget
        };

        return sMove;
    }
}
