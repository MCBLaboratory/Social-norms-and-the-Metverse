using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Animation2 : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;
    public GameObject gameObjectAnimation;
    public Animator animatorObject;
    
    public bool finishedPlaying = false;

    // Start is called before the first frame update

    public void Start()
    {

    }

    public void PlayAnimation()
    {
        animatorObject.enabled = true;
        animatorObject.Play("fade_out"); // Replace "YourAnimationName" with the name of your animation
    }

    void Update()
    {
        finishedPlaying = true;
    }
}
