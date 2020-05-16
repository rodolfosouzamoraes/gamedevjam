using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverPannelCtlr : MonoBehaviour
{
    public void RestartLevel(){
        CanvasMainMng.Instance.RestartLevel();
    }
    public void ExitLevel(){
        CanvasMainMng.Instance.ExitLevel();
    }
}
