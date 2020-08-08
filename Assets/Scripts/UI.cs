using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject panel;
    public GameObject controlBlocker;

    public void OpenPanel() 
    {
        if (panel != null && controlBlocker != null) 
        {
            controlBlocker.SetActive(true);
            panel.SetActive(true);
        }
    }

    public void ClosePanel() 
    {
        if (panel != null && controlBlocker != null)
        {
            controlBlocker.SetActive(false);
            panel.SetActive(false);
        }
    }


}
