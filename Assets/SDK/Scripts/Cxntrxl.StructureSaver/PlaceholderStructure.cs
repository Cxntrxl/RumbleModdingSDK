using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderStructure : MonoBehaviour
{
    public StructureType type;

    [Tooltip("State - Default; Not moving, not grounded.\n" +
        "StableGrounded - Not moving, grounded.\n" +
        "FreeGrounded - Moving, grounded.\n" +
        "Float - Parried.\n" +
        "Frozen - Mid-Collision or hitstopped.\n" +
        "Free - Moving, not grounded.")]
    public StructureState state;
}

public enum StructureType
{
    disc, pillar, ball, cube, wall
}

/// <summary>
/// [EXPERIMENTAL] Structure state not guaranteed to work as intended.
/// </summary>
public enum StructureState
{
    /// <summary>
    /// Default; Not moving, not grounded.
    /// </summary>
    State,

    /// <summary>
    /// Not moving, grounded.
    /// </summary>
    StableGrounded,

    /// <summary>
    /// Moving, grounded.
    /// </summary>
    FreeGrounded, 

    /// <summary>
    /// Parried.
    /// </summary>
    Float,

    /// <summary>
    /// Mid-Collision or hitstopped.
    /// </summary>
    Frozen,

    /// <summary>
    /// Moving, not grounded.
    /// </summary>
    Free
}