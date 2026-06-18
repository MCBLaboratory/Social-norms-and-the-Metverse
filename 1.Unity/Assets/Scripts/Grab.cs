using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grab : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;
    public Renderer objectRenderer;
    public Color exitColor = Color.black;
    // Start is called before the first frame update

    void OnEnable()
    {
        grabInteractable.onHoverEntered.AddListener(OnHoverEnter);
        grabInteractable.onHoverExited.AddListener(OnHoverExit);
    }

    void OnDisable()
    {
        grabInteractable.onHoverEntered.RemoveListener(OnHoverEnter);
        grabInteractable.onHoverExited.RemoveListener(OnHoverExit);
    }

    void OnHoverEnter(XRBaseInteractor interactor)
    {
 
            float r = 0.8f;
            float g = 0.9f;
            float b = 1.0f;

            Color tempLightBlue = new Color(r, g, b);

            Material temp1 = objectRenderer.material;
            temp1.color = tempLightBlue;

    }

    void OnHoverExit(XRBaseInteractor interactor)
    {

            Material temp1 = objectRenderer.material;
            temp1.color = exitColor;
        
    }
}