using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SensibilityMouseCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar sensibility;

    public void SetScrollbarValue()
    {
        sensibility.value = (PlayerPrefs.GetFloat("MouseSensibility")/50)-1;
    }

    public void SaveSensibility()
    {
        PlayerPrefs.SetFloat("MouseSensibility", (sensibility.value+1)*50);
        
    }
}
