using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinPannelCtlr : MonoBehaviour
{
    public void NextLevel(){
        SceneManager.LoadScene(CanvasMainMng.indexScene+1);
    }
    public void ExitLevel(){
        CanvasMainMng.Instance.ExitLevel();
    }
}
