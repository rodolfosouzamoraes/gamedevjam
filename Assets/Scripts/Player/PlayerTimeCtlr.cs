using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeCtlr : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Time") && !TimeMng.Instance.isTimeActived && CanvasMainMng.TimeBarPannel.qtdTimeBar>0 && !CanvasMainMng.Instance.isEndGame && !CanvasMainMng.Instance.isPauseActived){
            CanvasMainMng.TimeBarPannel.ConsumeTimeBar();
            TimeMng.Instance.StopTime();
        }
    }
}
