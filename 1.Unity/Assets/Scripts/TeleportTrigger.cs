using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public MainFile mainFile;
    public bool firstEnter = false;
    // Start is called before the first frame update
    public void FirstChoiceTrigger()
    {
        if(!firstEnter)
        {
            string temp = "Start Choice 1";
            int temp2 = 1;
            mainFile.RecordEventTypeStartChoice(temp, temp2);
            firstEnter = true;
        }
    }
}
