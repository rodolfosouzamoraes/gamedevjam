using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SensibilityMouseCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar sensibility;

    public void SetScrollbarValue()
    {
        sensibility.value = (DBMng.MouseSensibility()/50)-1;
    }

    public void SaveSensibility()
    {
        DBMng.SetMouseSensibility((sensibility.value+1)*50);
        
    }
}
