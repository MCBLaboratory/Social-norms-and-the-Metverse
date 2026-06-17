using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChoiceSelectGroup4 : MonoBehaviour
{
    public string eventString = "";
    public Group4 group4;
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
            group4.SubmitChoice(eventString);
            audioSource1.Play();
            
            grabbedFirst = true;
        }
    }
}
