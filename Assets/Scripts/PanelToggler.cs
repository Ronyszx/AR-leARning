using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour
{
   bool isOn = false ;
   [SerializeField] GameObject informationPanel;

   public void togglePanel()
   {
    if(isOn)
    {
        informationPanel.SetActive(false);
        isOn = false;
    }
    else
    {
        informationPanel.SetActive(true);
        isOn = true;
    }
   }
}
