using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinPannelCtlr : MonoBehaviour
{
    public void NextLevel(){
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex+1);
    }
    public void ExitLevel(){
        CanvasMainMng.Instance.ExitLevel();
    }
}
