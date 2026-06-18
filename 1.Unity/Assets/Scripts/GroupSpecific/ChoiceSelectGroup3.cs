using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChoiceSelectGroup3 : MonoBehaviour
{
    public string eventString = "";
    public Group3 group3;
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
            group3.SubmitChoice(eventString);
            audioSource1.Play();
            
            grabbedFirst = true;
        }
    }
}
