
using UnityEngine;
using TMPro;
using System.Text;

public class DebugManager : MonoBehaviour
{
    public TextMeshProUGUI textDebug;

    private StringBuilder logStringBuilder = new StringBuilder();

    private void OnEnable()
    { 
        SetEvents();
    }

     private void OnDisable() 
    {
        ClearEvents();
    }

    private void SetEvents(){
        Application.logMessageReceived += OnLogMessage;

    }

    private void ClearEvents(){
        Application.logMessageReceived -= OnLogMessage;

    }

    private void OnLogMessage(string pCondition, string pStackTrace, LogType pLogType ){
    logStringBuilder.Append(pCondition + "\n");
    textDebug.text = logStringBuilder.ToString();
    }
    
}
