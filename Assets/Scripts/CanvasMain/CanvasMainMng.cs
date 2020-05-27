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
    public static TutorialPannelCtlr TutorialPannel;

    public static int indexScene;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance==null){
            Time.timeScale = 1;
            indexScene = SceneManager.GetActiveScene().buildIndex;
            HourglassPannel = FindObjectOfType<HourglassPannelCtlr>();
            TimeBarPannel = FindObjectOfType<TimeBarPannelCtlr>();
            GameOverPannel = FindObjectOfType<GameOverPannelCtlr>();
            TutorialPannel = FindObjectOfType<TutorialPannelCtlr>();
            HideTutorial();
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] GameObject pnlGameOver;
    [SerializeField] GameObject pnlPause;
    [SerializeField] GameObject pnlWin;
    [SerializeField] GameObject pnlTutorial;
    public bool isEndGame = false;
    public bool isPauseActived;

    void Update()
    {
        if(!isEndGame){
            CheckPauseButton();
        }
        
    }
    /// <summary>
    /// Verifica se o pause foi acionado
    /// </summary>
    void CheckPauseButton(){
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
    /// <summary>
    /// Mostra o painel de pause
    /// </summary>
    public void ShowPausePannel(){
        pnlPause.SetActive(true);
    }
    /// <summary>
    /// Desativa o painel de pause
    /// </summary>
    public void HidePausePannel(){
        isPauseActived = !isPauseActived;
        Time.timeScale = 1;
        pnlPause.SetActive(false);
    }
    /// <summary>
    /// Ativa o painel de vitória
    /// </summary>
    public void ShowWinPannel(){
        AudioManager.Instance.LowerVolumes();
        AudioManager.Instance.Play(Audio.EndGame, Clip.Victory, false);
        PlayerPrefs.SetInt("Level_"+(indexScene+1),1);
        EndGame();
        pnlWin.SetActive(true);
    }
    /// <summary>
    /// Ativa o game over
    /// </summary>
    public void ShowGameOverPannel(){
        AudioManager.Instance.LowerVolumes();
        AudioManager.Instance.Play(Audio.EndGame, Clip.GameOver, false);
        EndGame();
        pnlGameOver.SetActive(true);
    }
    /// <summary>
    /// Finaliza as interações no jogo
    /// </summary>
    void EndGame(){
        isEndGame = true;
        PlayerMng.GameObjectPlayer.SetActive(false);
    }
    /// <summary>
    /// Reinicia a cena
    /// </summary>
    public void RestartLevel(){
        SceneManager.LoadScene(indexScene);
    }
    /// <summary>
    /// Volta para a cena do menu
    /// </summary>
    public void ExitLevel(){
        SceneManager.LoadScene(0);
    }

    public void ShowTutorial(string message){
        pnlTutorial.SetActive(true);
        TutorialPannel.SetMessage(message);
    }

    public void HideTutorial(){
        TutorialPannel.SetMessage(" ");
        pnlTutorial.SetActive(false);
    }
}
