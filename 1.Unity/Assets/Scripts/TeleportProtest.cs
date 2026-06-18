using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportProtest : MonoBehaviour
{
    public GameObject positionPlayer;
    public Transform respawnPoint;
    
    public void RespawnProcedure()
    {
        positionPlayer.transform.position = respawnPoint.position;
    }
}
