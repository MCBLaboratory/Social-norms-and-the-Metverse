using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Group1 : MonoBehaviour
{
    [Header("Settings")]
    public MainFile mainFile;
    public int numChoice = 1;
    public int numChoiceStart = 0;
    public TextMeshProUGUI textBox;
    
    [Header("ObjectsItem")]
    public GameObject beefBurger;
    public GameObject chickenWrap;
    public GameObject blackBeanBurger;
    public GameObject wrapChickPeas;
    public TextMeshProUGUI priceTag1;
    public TextMeshProUGUI priceTag2;

    [Header("Datalogging file")]
    public string itemLeft;
    public string itemRight;
    private string eventTypeString = "";
    private string eventTypeString2 = "";

    public void SubmitChoice(string choice)
    {
        if(numChoice == 1 && choice == "Beef burger")
        {
            mainFile.itemChosen = "Beef burger";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Left";
            beefBurger.SetActive(true);
            blackBeanBurger.SetActive(true);
            eventTypeString = "Choice 1";
            eventTypeString2 = "Start Choice 2";
            textBox.text = "Unfortunately, the <u>beef burger</u> is out of stock. We have a <u>black bean burger</u> instead.";
            priceTag1.text = "Black bean burger\n\n€ 4,95,-";
        }

        if(numChoice == 1 && choice == "Chicken wrap")
        {
            mainFile.itemChosen = "Chicken wrap";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Right";
            chickenWrap.SetActive(true);
            wrapChickPeas.SetActive(true);
            eventTypeString = "Choice 1";
            eventTypeString2 = "Start Choice 2";
            textBox.text = "Unfortunately, the <u>chicken wrap</u> is out of stock. We have a <u>wrap w/ chickpeas</u> instead.";
            priceTag2.text = "Wrap chickpeas\n\n€ 4,95,-";
        }

        if(numChoice == 2 && choice == "Black bean burger")
        {
            mainFile.itemChosen = "Black bean burger";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Left";
            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 2 && choice == "Chicken wrap")
        {
            mainFile.itemChosen = "Chicken wrap";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Right";
            if(beefBurger.active)
            {
                beefBurger.SetActive(false); 
                chickenWrap.SetActive(true);
            }
            else{chickenWrap.SetActive(true);}

            wrapChickPeas.SetActive(true);
            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
            textBox.text = "Unfortunately, the <u>chicken wrap</u> is out of stock. We have a <u>wrap w/ chickpeas</u> instead.";
            priceTag2.text = "Wrap chickpeas\n\n€ 4,95,-";
        }

        if(numChoice == 2 && choice == "Wrap chickpeas")
        {
            mainFile.itemChosen = "Wrap chickpeas";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Right";
            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 2 && choice == "Beef burger")
        {
            mainFile.itemChosen = "Beef burger";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Left";
            if(chickenWrap.active)
            {
                beefBurger.SetActive(true); 
                chickenWrap.SetActive(false);
            }
            else{beefBurger.SetActive(true);}
            
            beefBurger.SetActive(true);
            blackBeanBurger.SetActive(true);
            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
            textBox.text = "Unfortunately, the <u>beef burger</u> is out of stock. We have a <u>black bean burger</u> instead.";
            priceTag1.text = "Black bean burger\n\n€ 4,95,-";
        }

        if(numChoice == 3 && choice == "Wrap chickpeas")
        {
            mainFile.itemChosen = "Wrap chickpeas";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Right";
            eventTypeString = "Choice 3";
            eventTypeString2 = "Start Choice 4";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 3 && choice == "Black bean burger")
        {
            mainFile.itemChosen = "Black bean burger";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Left";
            eventTypeString = "Choice 3";
            eventTypeString2 = "Start Choice 4";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 3 && choice == "Chicken wrap")
        {
            mainFile.itemChosen = "Chicken wrap";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Right";
            if(beefBurger.active)
            {
                beefBurger.SetActive(false); 
                chickenWrap.SetActive(true);
            }
            else{chickenWrap.SetActive(true);}

            wrapChickPeas.SetActive(true);
            eventTypeString = "Choice 3";
            eventTypeString2 = "Start Choice 4";
            textBox.text = "Unfortunately, the <u>chicken wrap</u> is out of stock. We have a <u>wrap w/ chickpeas</u> instead.";
            priceTag2.text = "Wrap chickpeas\n\n€ 4,95,-";
        }

        if(numChoice == 3 && choice == "Beef burger")
        {
            mainFile.itemChosen = "Beef burger";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Left";
            if(chickenWrap.active)
            {
                beefBurger.SetActive(true); 
                chickenWrap.SetActive(false);
            }
            else{beefBurger.SetActive(true);}
            
            blackBeanBurger.SetActive(true);
            eventTypeString = "Choice 3";
            eventTypeString2 = "Start Choice 4";
            textBox.text = "Unfortunately, the <u>beef burger</u> is out of stock. We have a <u>black bean burger</u> instead.";
            priceTag1.text = "Black bean burger\n\n€ 4,95,-";
        }

        if(numChoice == 4 && choice == "Wrap chickpeas")
        {
            mainFile.itemChosen = "Wrap chickpeas";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Right";
            eventTypeString = "Choice 4";
            eventTypeString2 = "Start Choice 5";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 4 && choice == "Black bean burger")
        {
            mainFile.itemChosen = "Black bean burger";
            mainFile.itemLeft = "Black bean burger";
            mainFile.itemRight = "Wrap chickpeas";
            mainFile.sideItemChosen = "Left";
            eventTypeString = "Choice 4";
            eventTypeString2 = "Start Choice 5";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 4 && choice == "Chocolate")
        {
            mainFile.itemChosen = "Chocolate";
            mainFile.itemLeft = "Chocolate";
            mainFile.itemRight = "Fruit";
            mainFile.sideItemChosen = "Left";
            eventTypeString = "Choice 4";
            eventTypeString2 = "Start Choice 5";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 4 && choice == "Fruit")
        {
            mainFile.itemChosen = "Fruit";
            mainFile.itemLeft = "Chocolate";
            mainFile.itemRight = "Fruit";
            mainFile.sideItemChosen = "Right";
            eventTypeString = "Choice 4";
            eventTypeString2 = "Start Choice 5";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(choice == "Chocolate")
        {
            mainFile.itemChosen = "None";
            mainFile.itemLeft = "None";
            mainFile.itemRight = "None";
            mainFile.sideItemChosen = "Left";
            mainFile.sideItemChosen1 = "Chocolate";
            eventTypeString = "Choice " + numChoice.ToString();
            eventTypeString2 = "End Choice " + numChoice.ToString();
        }

        if(choice == "Fruit")
        {
            mainFile.itemChosen = "None";
            mainFile.itemLeft = "None";
            mainFile.itemRight = "None";
            mainFile.sideItemChosen = "Right";
            mainFile.sideItemChosen2 = "Fruit";
            eventTypeString = "Choice " + numChoice.ToString();
            eventTypeString2 = "End Choice " + numChoice.ToString();
        }

        if(numChoice < 7)
        {
            mainFile.RecordEventType(eventTypeString, numChoice);
            numChoice++;

            numChoiceStart = numChoice;
            mainFile.RecordEventTypeStartChoice(eventTypeString2, numChoiceStart);
        }
    }
}
