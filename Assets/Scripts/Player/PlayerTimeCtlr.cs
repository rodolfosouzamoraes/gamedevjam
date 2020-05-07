using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeCtlr : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Time") && !TimeMng.Instance.isTimeActived){
            TimeMng.Instance.StopTime();
        }
    }
}
