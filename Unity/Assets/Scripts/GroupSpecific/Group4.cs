using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Group4 : MonoBehaviour
{
    [Header("Settings")]
    public MainFile mainFile;
    public int numChoice = 1;
    public int numChoiceStart = 0;
    public TextMeshProUGUI textBox;
    
    [Header("ObjectsItem")]
    public GameObject beefBurger;
    public GameObject chickenWrap;
    public GameObject alternative1;
    public GameObject alternative2;
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
            eventTypeString = "Choice 1";
            eventTypeString2 = "Start Choice 2";
        }

        if(numChoice == 1 && choice == "Chicken wrap")
        {
            mainFile.itemChosen = "Chicken wrap";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Right";
            eventTypeString = "Choice 1";
            eventTypeString2 = "Start Choice 2";
        }

        if(numChoice == 2 && choice == "Chicken wrap")
        {
            mainFile.itemChosen = "Chicken wrap";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Right";

            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
        }

        if(numChoice == 2 && choice == "Beef burger")
        {
            mainFile.itemChosen = "Beef burger";
            mainFile.itemLeft = "Beef burger";
            mainFile.itemRight = "Chicken wrap";
            mainFile.sideItemChosen = "Left";

            eventTypeString = "Choice 2";
            eventTypeString2 = "Start Choice 3";
        }


        if(numChoice == 3 && choice == "Chocolate")
        {
            mainFile.itemChosen = "Chocolate";
            mainFile.itemLeft = "Chocolate";
            mainFile.itemRight = "Fruit";
            mainFile.sideItemChosen = "Left";
            eventTypeString = "Choice 4";
            eventTypeString2 = "Start Choice 5";
            textBox.text = "Great choice! Please proceed to checkout.";
        }

        if(numChoice == 3 && choice == "Fruit")
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
