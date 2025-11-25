using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    public void Openurl(string urlname)
    {
        Application.OpenURL(urlname);
    }


}

