using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPannelActivedCtlr : MonoBehaviour
{
    [SerializeField] int idPannel;
    
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        PlayerPrefs.SetInt("LastPannel", idPannel);
    }
}
