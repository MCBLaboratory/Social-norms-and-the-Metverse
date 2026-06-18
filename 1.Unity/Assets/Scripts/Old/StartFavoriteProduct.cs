using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using LSL;

public class StartFavoriteProduct : MonoBehaviour
{
    public MainItem mainObjectFile;
    public XRGrabInteractable grabInteractableScript;
    public GameObject enableItems;
    public GameObject startButton;

    public TextMeshProUGUI stageNum;

    public XRInteractorLineVisual rayInteractorL;
    public XRInteractorLineVisual rayInteractorR;

    [Header("LSL")]
    private StreamOutlet outlet;
    private string[] sample = {""};

    void Start()
    {
        grabInteractableScript.onSelectEntered.AddListener(OnObjectGrabbed);
    }

    void OnEnable()
    {
        grabInteractableScript.onHoverEntered.AddListener(OnHoverEnter);
        grabInteractableScript.onHoverExited.AddListener(OnHoverExit);
    }

    void OnDisable()
    {
        grabInteractableScript.onHoverEntered.RemoveListener(OnHoverEnter);
        grabInteractableScript.onHoverExited.RemoveListener(OnHoverExit);
    }

    void OnHoverEnter(XRBaseInteractor interactor)
    {
        rayInteractorL.enabled = true;
        rayInteractorR.enabled = true;
    }

    void OnHoverExit(XRBaseInteractor interactor)
    {
        rayInteractorL.enabled = false;
        rayInteractorR.enabled = false;
    }

    public void OnObjectGrabbed(XRBaseInteractor interactor)
    {
        enableItems.SetActive(true);
        startButton.SetActive(false);
        grabInteractableScript.onSelectEntered.RemoveListener(OnObjectGrabbed);
        stageNum.text = "Choose your favorite packaging";

        //LSL
        sample[0] = "Start FavoriteProductGrabbing";
        Debug.Log(sample[0]);
        mainObjectFile.PushSampleToOutlet(sample);
        //
    }
}
