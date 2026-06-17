using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using System.IO;

public class MainFile : MonoBehaviour
{
    [Header("ParticipantID")]
    public string participantID = "";

    [Header("Objects")]
    public string itemLeft = "None";
    public string itemRight = "None";
    public string itemChosen = "None";
    public string sideItemChosen = "None";
    public int eventNum = -1;
    public int eventNum1 = 0;
    public string eventType1 = "None";

    [Header("Random seed")]
    public int randomSeed;

    private string csvFilePath;
    public int groupNumber;
    public string sideItemChosen1 = "None";
    public string sideItemChosen2 = "None";
    public string finalItemChosen = "None";
    
    // Start is called before the first frame update
    void Start()
    {
        randomSeed = System.DateTime.Now.Millisecond;
        UnityEngine.Random.InitState(randomSeed);
        string timestamp = System.DateTime.Now.ToString("MM-dd_HH-mm");
        string timestamp1 = System.DateTime.Now.ToString("HHmm");
        participantID = timestamp1.ToString() + Random.Range(0, 100).ToString();
        Debug.Log("Participant ID: " + participantID);

        eventNum = -1;

        // Define the path for the .csv file
        csvFilePath = Application.dataPath + "/Data/" + timestamp + "_" + "ID" + participantID + " LoggingData.csv";
    }

    public void GroupNumber(int groupNumberInput)
    {
        groupNumber = groupNumberInput;
    }

    public void RecordEventType1(string eventType)
    {
        // Get current timestamp
        //string timestamp = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
        string date = System.DateTime.Now.ToString("yyyy-MM-dd");
        string timestamp = System.DateTime.Now.ToString("HH:mm:ss:fff");

        // Write data to .csv file
        if(eventType == "GroupSelect") {eventNum = 0;}
        string data0 = $"{date},{participantID},{groupNumber},{eventType},{eventNum},{itemLeft},{itemRight},{itemChosen},{sideItemChosen},{sideItemChosen1},{sideItemChosen2},{finalItemChosen},{timestamp},{randomSeed}";
        WriteToCSV(data0);
        eventNum1 = eventNum;
        eventType1 = eventType;
    }

    public void RecordEventType(string eventType, int eventNum)
    {
        // Get current timestamp
        string date = System.DateTime.Now.ToString("yyyy-MM-dd");
        string timestamp = System.DateTime.Now.ToString("HH:mm:ss:fff");

        // Write data to .csv file
        string data0 = $"{date},{participantID},{groupNumber},{eventType},{eventNum},{itemLeft},{itemRight},{itemChosen},{sideItemChosen},{sideItemChosen1},{sideItemChosen2},{finalItemChosen},{timestamp},{randomSeed}";
        WriteToCSV(data0);
        eventNum1 = eventNum;
        eventType1 = eventType;
    }

    public void RecordEventTypeStartChoice(string eventType, int eventNum)
    {
        // Get current timestamp
        string date = System.DateTime.Now.ToString("yyyy-MM-dd");
        string timestamp = System.DateTime.Now.ToString("HH:mm:ss:fff");
        
        itemChosen = "None";
        sideItemChosen = "None";
        itemLeft = "None";
        itemRight = "None";

        // Write data to .csv file
        string data0 = $"{date},{participantID},{groupNumber},{eventType},{eventNum},{itemLeft},{itemRight},{itemChosen},{sideItemChosen},{sideItemChosen1},{sideItemChosen2},{finalItemChosen},{timestamp},{randomSeed}";
        WriteToCSV(data0);
        eventNum1 = eventNum;
        eventType1 = eventType;
    }

    public void RecordEventTypeFinalChoice(string eventType, string sideItemChosen1, string sideItemChosen2, string finalItemChosen)
    {
        // Get current timestamp
        string date = System.DateTime.Now.ToString("yyyy-MM-dd");
        string timestamp = System.DateTime.Now.ToString("HH:mm:ss:fff");

        // Write data to .csv file
        itemChosen = "None";
        sideItemChosen = "None";
        itemLeft = "None";
        itemRight = "None";
        eventNum = eventNum1;
        eventType1 = eventType;

        string data0 = $"{date},{participantID},{groupNumber},{eventType},{eventNum},{itemLeft},{itemRight},{itemChosen},{sideItemChosen},{sideItemChosen1},{sideItemChosen2},{finalItemChosen},{timestamp},{randomSeed}";
        WriteToCSV(data0);
    }
    
    private void WriteToCSV(string data)
    {
        // Check if .csv file exists, if not, create it and write header
        if (!File.Exists(csvFilePath))
        {
            // Write header to .csv file
            File.WriteAllText(csvFilePath, "date,participantID,groupNumber,eventType,eventNum,itemLeft,itemRight,itemChosen,leftOrRight,sideItemChosen1,sideItemChosen2,finalItemChosen,Timestamp(H:M:S:MS),randomSeed\n");
        }

        // Check if the file is empty
        if (new FileInfo(csvFilePath).Length == 0)
        {
            // Write header to .csv file
            File.WriteAllText(csvFilePath, "date,participantID,groupNumber,eventType,eventNum,itemLeft,itemRight,itemChosen,leftOrRight,sideItemChosen1,sideItemChosen2,finalItemChosen,Timestamp(H:M:S:MS),randomSeed\n");
    }

        // Append data to .csv file
        File.AppendAllText(csvFilePath, data + "\n");
    }
}
