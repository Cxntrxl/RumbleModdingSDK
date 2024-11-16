using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("Photon.Pun.MonoBehaviourPun, PhotonUnityNetworking")]
public class MonoBehaviourPun : MonoBehaviour
{
    public PhotonView photonView;
    public PhotonView pvCache;
}
