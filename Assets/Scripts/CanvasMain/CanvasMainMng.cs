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
            Time.timeScale = 1;
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
    [SerializeField] GameObject pnlPause;
    public bool isGameOver = false;
    public bool isPauseActived;

    void Update()
    {
        if(Input.GetButtonDown("Pause")){
            if(!isPauseActived){
                isPauseActived = !isPauseActived;
                ShowPausePannel();
                Time.timeScale = 0;
            }
            else{
                HidePausePannel();
            }
            
        }
    }
    public void ShowPausePannel(){
        pnlPause.SetActive(true);
    }

    public void HidePausePannel(){
        isPauseActived = !isPauseActived;
        Time.timeScale = 1;
        pnlPause.SetActive(false);
    }

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
