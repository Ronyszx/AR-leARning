using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARApp.UI

{
    public class UIManager : MonoBehaviour
        {
            public static UIManager instance;
            
            private void Awake()
                {
                    instance = this;
                }       

   
        }
}
