using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePannelCtlr : MonoBehaviour
{
    public void ResumeGame(){
        CanvasMainMng.Instance.HidePausePannel();
    }
    public void RestartLevel(){
        CanvasMainMng.Instance.RestartLevel();
    }
    public void ExitLevel(){
        CanvasMainMng.Instance.ExitLevel();
    }
}
