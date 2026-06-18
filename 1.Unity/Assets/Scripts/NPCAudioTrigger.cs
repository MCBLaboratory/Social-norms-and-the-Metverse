using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAudioTrigger : MonoBehaviour
{
    public NPCOrientation npcOrientation;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckAudio", 0f, 0.5f);
    }

    // Update is called once per frame
    void CheckAudio()
    {
        if(audioSource.isPlaying)
        {
            //npcOrientation.ActivateNPC();
        }
    }
}
