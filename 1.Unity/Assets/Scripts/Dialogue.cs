using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Dialogue : MonoBehaviour
{
    public AudioClip[] dialogueClip_1;
    public AudioClip[] dialogueClip_2;
    public AudioSource source_c1;
    public AudioSource source_c2;
    public AudioSource pingSource;
    public Animator animator1;
    public Animator animator2;

    public bool scenario3 = false;
    public Dialogue dialogue_2;
    public XRRayInteractor teleportInteractor;
    private bool enableFirstTimer = true;
    private bool firstTimePlaying = false;
    public float firstTimer = 15f;

    public bool inRange = false;
    public bool activateSpeaker_1 = true;
    public bool isPlaying = false;
    private int numDialogue_1;
    private int numDialogue_2;
    private bool scenario3DisableSound = false;
    public NPCOrientation1 activateNPC_3;

    public NPCMovement_3 NPCMovement_3_gameObject;


    public void ActivateInRange()
    {
        inRange = true;
        if(!isPlaying)
        {
            StartCoroutine(PlayDialogue());
            enableFirstTimer = false;
        }
    }

    public void DeactivateInRange()
    {
        inRange = false;
        StopAllCoroutines();
        ResetDialogue();
    }

    // Update is called once per frame
    public IEnumerator PlayDialogue()
    {   
        isPlaying = true;

        while(inRange)
        {
            if(numDialogue_1 < dialogueClip_1.Length)
            {
                source_c1.clip = dialogueClip_1[numDialogue_1];
                source_c1.Play();
                yield return new WaitForSeconds(source_c1.clip.length);
                numDialogue_1++;
            }

            if(numDialogue_2 < dialogueClip_2.Length)
            {
                source_c2.clip = dialogueClip_2[numDialogue_2];
                source_c2.Play();
                yield return new WaitForSeconds(source_c2.clip.length);
                numDialogue_2++;
            }

            if (numDialogue_1 >= dialogueClip_1.Length && numDialogue_2 >= dialogueClip_2.Length)
            {
                if(scenario3)
                {
                    dialogue_2.ActivateInRange();
                    activateNPC_3.ActivateNPC();
                    scenario3DisableSound = true;
                }
                break;
            }

        }

        isPlaying = false;
        NPCMovement_3_gameObject.EnableNPCMovement();
        if(numDialogue_1 >= dialogueClip_1.Length && numDialogue_2 >= dialogueClip_2.Length && !scenario3)
        {
            NPCMovement_3_gameObject.EnableNPCMovement1();
        }
    }

    void ResetDialogue()
    {
        numDialogue_1 = 0;
        numDialogue_2 = 0;
        isPlaying = false;
        enableFirstTimer = false;
    }

    void Update()
    {
         if(!enableFirstTimer && !firstTimePlaying && !scenario3 && !scenario3DisableSound)
        {
            firstTimer -= Time.deltaTime;
            
            if(firstTimer < 14.5f)
            {
                teleportInteractor.enabled = false;
            }
            
            if(firstTimer < 0f)
            {
                pingSource.Play();
                teleportInteractor.enabled = true;
                firstTimePlaying = true;
                enableFirstTimer = false;
                firstTimer = 15f;
            }
        }
    }
}
