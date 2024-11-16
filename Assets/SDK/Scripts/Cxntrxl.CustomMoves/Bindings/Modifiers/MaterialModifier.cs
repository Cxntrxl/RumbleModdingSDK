using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.MoveSystem.MaterialModifier, RUMBLE.Runtime")]
[CreateAssetMenu(fileName = "CustomMaterialModifier", menuName = "Cxntrxl.CustomMoves/Modifiers/MaterialModifier", order = 15)]
public class MaterialModifier : Modifier
{
    public Material NewMaterial;
}
