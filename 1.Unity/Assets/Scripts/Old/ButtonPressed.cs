using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPressed : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;
    public AudioSource buttonPressedSound;
    public AudioClip clipSound;

    // Start is called before the first frame update
    void Start()
    {
        buttonPressedSound.clip = clipSound;
        grabInteractable.onSelectEntered.AddListener(OnObjectGrabbed);
    }

    // Update is called once per frame
    public void OnObjectGrabbed(XRBaseInteractor interactor)
    {
        if (buttonPressedSound != null)
        {
            buttonPressedSound.Play();
        }
    }

    void OnDestroy()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnObjectGrabbed);
    }
}
