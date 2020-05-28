using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Classe responsável por alterar os itens do toolbar
/// </summary>
public class TimeBarPannelCtlr : MonoBehaviour
{
    [Header("Sprites da barra de estamina")]
    [SerializeField] Sprite[] sptTimeBars;
    [Header("Imagem da time bar")]
    [SerializeField] Image imgTimeBar;
    [SerializeField] Text txtTimeCountBack;
    [SerializeField] Text txtTimeCount;
    [SerializeField] Text txtCountCristalBlack;
    [SerializeField] Text txtCountCristal;
    public int qtdTimeBar;
    private int qtdTImeBarOriginal;
    public float timer;
    public bool isCountTimer = true;
    public int scoreCristal = 0;
    // Start is called before the first frame update
    void Start()
    {
        qtdTimeBar = sptTimeBars.Length -1;
        imgTimeBar.sprite = sptTimeBars[qtdTimeBar];
        qtdTImeBarOriginal = qtdTimeBar;
        timer = 0;
        IncreaseCristal(0);
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(isCountTimer){
            timer = Time.timeSinceLevelLoad;
            var ts = TimeSpan.FromSeconds(timer);
            txtTimeCountBack.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            txtTimeCount.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }
    }
    /// <summary>
    /// Consome a barra do tempo
    /// </summary>
    public void ConsumeTimeBar(){
        qtdTimeBar -=1;
        if(qtdTimeBar<=0){
            qtdTimeBar = 0;
        }
        imgTimeBar.sprite = sptTimeBars[qtdTimeBar];
    }

    public bool IncreaseTimeBar(){
        if(qtdTimeBar+1<=qtdTImeBarOriginal){
            qtdTimeBar+=1;
            imgTimeBar.sprite = sptTimeBars[qtdTimeBar];
            return true;
        }
        else{
            return false;
        }
    }

    public void IncreaseCristal(int point){
        scoreCristal += point;
        txtCountCristalBlack.text ="x"+scoreCristal;
        txtCountCristal.text = "x"+scoreCristal;
    }
}
