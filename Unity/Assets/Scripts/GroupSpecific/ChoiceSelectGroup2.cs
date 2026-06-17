using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChoiceSelectGroup2 : MonoBehaviour
{
    public string eventString = "";
    public Group2 group2;
    public XRGrabInteractable grabInteractable;

    public AudioSource audioSource1;
    public bool grabbedFirst = false;
    
    // Start is called before the first frame update
    void Start()
    {
        grabInteractable.onSelectEntered.AddListener(OnObjectGrabbed);
    }

    void OnObjectGrabbed(XRBaseInteractor interactor)
    {
        if(!grabbedFirst)
        {
            group2.SubmitChoice(eventString);
            audioSource1.Play();
            
            grabbedFirst = true;
        }
    }
}
