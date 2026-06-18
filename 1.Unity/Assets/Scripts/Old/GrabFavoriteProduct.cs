using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using LSL;

public class GrabFavoriteProduct : MonoBehaviour
{
    public MainItem mainObjectFile;
    public XRGrabInteractable grabInteractable;
    public Renderer objectRenderer;
    public GameObject[] disableItems;

    public TextMeshProUGUI stageNum;
    public GameObject finalText;

    public AudioSource finalAudio;
    private bool playedOnce = false;

    public XRInteractorLineVisual rayInteractorL;
    public XRInteractorLineVisual rayInteractorR;

    [Header("LSL")]
    private StreamOutlet outlet;
    private string[] sample = {""};

    void Start()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnObjectGrabbed);
        grabInteractable.onSelectEntered.AddListener(OnObjectGrabbed);
    }

    void OnDestroy()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnObjectGrabbed);
    }

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

        rayInteractorL.enabled = true;
        rayInteractorR.enabled = true;
    }

    void OnHoverExit(XRBaseInteractor interactor)
    {
        Material temp1 = objectRenderer.material;
        temp1.color = Color.white;

        rayInteractorL.enabled = false;
        rayInteractorR.enabled = false;
    }

    public void OnObjectGrabbed(XRBaseInteractor interactor)
    {
        
        string itemType = "FavoriteProduct";
        string itemDiverseTarget = objectRenderer.material.ToString();
        itemDiverseTarget = itemDiverseTarget.Replace(" (Instance) (UnityEngine.Material)", "");
        string eventType = "FavoriteProductGrabbing";
        mainObjectFile.currentBlock = "None";
        
        mainObjectFile.RecordEvent(eventType, itemType, itemDiverseTarget);

        for(int i = 0; i < 10; i++)
        {
            disableItems[i].SetActive(false);
        }

        objectRenderer.material.color = Color.green;

        stageNum.text = "Finished experiment!";
        finalText.SetActive(true);
        if(!playedOnce)
        {
            finalAudio.Play();
            playedOnce = true;
        }
        
        //LSL
        sample[0] = "FavoriteProductGrabbing: " + itemDiverseTarget;
        Debug.Log(sample[0]);
        mainObjectFile.PushSampleToOutlet(sample);
        //
    }

}
