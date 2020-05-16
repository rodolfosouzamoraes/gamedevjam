using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Classe Responsável por gerenciar os painéis do menu
/// </summary>
public class MainMenuMng : MonoBehaviour
{
    public static MainMenuMng Instance;
    void Start()
    {
        if(Instance == null){
            PlayerPrefs.SetInt("Level_1",1);
            Time.timeScale = 1;
            ShowPannel(pannels[PlayerPrefs.GetInt("LastPannel")]);
            Instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
    
    [Header("Painéis do menu")]
    [SerializeField] List<PannelCtlr> pannels = new List<PannelCtlr>(); 

    /// <summary>
    /// Habilita o painel desejado
    /// </summary>
    /// <param name="pannel">Painel a ser aberto</param>
    public void ShowPannel(PannelCtlr pannel){
        Debug.Log("Cliquei");
        var pannelShow = pannels.FirstOrDefault(p => p.Compare(pannel));
        if(pannelShow!=null){
            foreach(PannelCtlr pnl in pannels){
                pnl.gameObject.SetActive(false);
            }
            pannelShow.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Fecha o jogo
    /// </summary>
    public void QuitAplication(){
        Application.Quit();
    }
}
