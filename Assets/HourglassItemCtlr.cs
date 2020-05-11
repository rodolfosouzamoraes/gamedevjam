using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourglassItemCtlr : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        var result = CanvasMainMng.TimeBarPannel.IncreaseTimeBar();
        if(result){
           Destroy(gameObject); 
        }   
    }
}
