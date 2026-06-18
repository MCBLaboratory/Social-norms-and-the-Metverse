using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class Checkout : MonoBehaviour
{
    public MainFile mainFile;
    public GameObject[] item1Main;
    public GameObject[] item2Main;
    public GameObject chocolateTray;
    public GameObject chocolateTrayM;
    public GameObject fruitTray;
    public GameObject fruitTrayA;

    public GameObject[] item1Real;
    public GameObject[] item2Real;

    public AudioSource audioSource;
    public TextMeshProUGUI textBox;

    private string sideItemChosen1 = "None";
    private string sideItemChosen2 = "None";
    public string finalItemChosen = "Empty";

    private bool firstItemChosen = false;
    
    public AudioSource finishedPrompt;
    public AudioSource emptyPrompt;
    public AudioClip emptyAudio;
    public int pressedNumEmpty = 0;

    public TextMeshProUGUI textBoxFinal;

    public XRGrabInteractable grabInteractable;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("RealBB"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[3].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "RealBB ";
                Destroy(item1Real[3]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("RealCW"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[3].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "RealCW ";
                Destroy(item2Real[3]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("BBB"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[0].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "BBB ";
                Destroy(item1Real[0]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("CW"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item2Main[0].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "CW ";
                Destroy(item2Real[0]);
                firstItemChosen = true;
            }
        }

        if(other.CompareTag("SxBBB"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[1].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "SxBBB ";
                Destroy(item1Real[1]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("SxCW"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item2Main[1].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "SxCW ";
                Destroy(item2Real[1]);
                firstItemChosen = true;
            }
        }

        if(other.CompareTag("BBBB"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[2].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "BBBB ";
                Destroy(item1Real[2]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("BC"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item2Main[2].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "BC ";
                Destroy(item2Real[2]);
                firstItemChosen = true;
            }
        }

        if(other.CompareTag("SxBBBB"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item1Main[3].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "SxBBBB ";
                Destroy(item1Real[3]);
                firstItemChosen = true;
            }
        }
        if(other.CompareTag("SxBC"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 4.95f;
                textBox.text = number2.ToString("f2");
                item2Main[3].SetActive(true);
                audioSource.Play();
                finalItemChosen = finalItemChosen + "SxBC ";
                Destroy(item2Real[3]);
                firstItemChosen = true;
            }
        }

        if(other.CompareTag("Chocolate"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 0.75f;
                textBox.text = number2.ToString("f2");
                chocolateTray.SetActive(true);
                audioSource.Play();
                sideItemChosen1 = "Chocolate";
                finalItemChosen = finalItemChosen + "Chocolate ";

                firstItemChosen = true;
            }

            XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("Chocolate"))
                {
                    interactable.enabled = false;
                }
            }

            XRGrabInteractable[] interactables1 = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables1)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("ChocolateM"))
                {
                    interactable.enabled = false;
                }
            }
            other.gameObject.SetActive(false);
        }

        if(other.CompareTag("ChocolateM"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 0.75f;
                textBox.text = number2.ToString("f2");
                chocolateTrayM.SetActive(true);
                audioSource.Play();
                sideItemChosen1 = "Chocolate";
                finalItemChosen = finalItemChosen + "Chocolate ";

                firstItemChosen = true;
            }
            XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("Chocolate"))
                {
                    interactable.enabled = false;
                }
            }

            XRGrabInteractable[] interactables1 = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables1)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("ChocolateM"))
                {
                    interactable.enabled = false;
                }
            }
            other.gameObject.SetActive(false);
        }

        if(other.CompareTag("Fruit"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 0.75f;
                textBox.text = number2.ToString("f2");
                fruitTray.SetActive(true);
                audioSource.Play();
                sideItemChosen2 = "Fruit";
                finalItemChosen = finalItemChosen + "Fruit ";

                firstItemChosen = true;
            }

            XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("Fruit"))
                {
                    interactable.enabled = false;
                }
            }

            XRGrabInteractable[] interactables1 = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables1)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("FruitA"))
                {
                    interactable.enabled = false;
                }
            }
            other.gameObject.SetActive(false);
        }
        if(other.CompareTag("FruitA"))
        {   
            if(!firstItemChosen) { finalItemChosen = "";}
            string textContent = textBox.text;

            float number;
            if(float.TryParse(textContent, out number))
            {
                float number2 = number + 0.75f;
                textBox.text = number2.ToString("f2");
                fruitTrayA.SetActive(true);
                audioSource.Play();
                sideItemChosen2 = "Fruit";
                finalItemChosen = finalItemChosen + "Fruit ";
                
                firstItemChosen = true;
            }

            XRGrabInteractable[] interactables1 = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables1)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("Fruit"))
                {
                    interactable.enabled = false;
                }
            }
            XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables)
            {
                if (interactable.gameObject != other.gameObject && interactable.CompareTag("FruitA"))
                {
                    interactable.enabled = false;
                }
            }
            other.gameObject.SetActive(false);
        }
    }

    public void SubmitOrder()
    {
        if(finalItemChosen == "Empty")
        {
            if(pressedNumEmpty > 0)
            {
                string eventType = "Final decision";
                mainFile.RecordEventTypeFinalChoice(eventType, sideItemChosen1, sideItemChosen2, finalItemChosen);
                finishedPrompt.Play();
                grabInteractable.enabled = false;
                DisableXRGI();
                textBoxFinal.text = "Thank you for your order!";
            }
            else
            {
                emptyPrompt.clip = emptyAudio;
                emptyPrompt.Play();
                pressedNumEmpty++;
            }
        }
        else
        {
            string eventType = "Final decision";
            mainFile.RecordEventTypeFinalChoice(eventType, sideItemChosen1, sideItemChosen2, finalItemChosen);
            finishedPrompt.Play();
            grabInteractable.enabled = false;
            DisableXRGI();
            textBoxFinal.text = "Thank you for your order!";
        }
        
    }

    void DisableXRGI()
    {
        XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();
            foreach (XRGrabInteractable interactable in interactables)
            {
                if (interactable.CompareTag("BBB") || interactable.CompareTag("CW") || interactable.CompareTag("SxBBB") || interactable.CompareTag("SxCW") || interactable.CompareTag("BBBB") || interactable.CompareTag("BC") || interactable.CompareTag("SxBC") || interactable.CompareTag("SxBBBB") || interactable.CompareTag("Chocolate") || interactable.CompareTag("ChocolateM") || interactable.CompareTag("Fruit") || interactable.CompareTag("FruitA")) 
                {
                    interactable.enabled = false;
                }
            }
    }
}
