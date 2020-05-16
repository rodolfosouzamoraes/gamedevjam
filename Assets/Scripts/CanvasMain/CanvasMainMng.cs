using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Classe responsável por gerenciar o canvas Main
/// </summary>
public class CanvasMainMng : MonoBehaviour
{
    public static CanvasMainMng Instance;
    public static HourglassPannelCtlr HourglassPannel;
    public static TimeBarPannelCtlr TimeBarPannel;
    public static GameOverPannelCtlr GameOverPannel;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance==null){
            HourglassPannel = FindObjectOfType<HourglassPannelCtlr>();
            TimeBarPannel = FindObjectOfType<TimeBarPannelCtlr>();
            GameOverPannel = FindObjectOfType<GameOverPannelCtlr>();
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] GameObject pnlGameOver;
    public bool isGameOver = false;
    public void ShowGameOverPannel(){
        pnlGameOver.SetActive(true);
    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitLevel(){
        SceneManager.LoadScene(0);
    }
}
