﻿using System.Collections;
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
    public int qtdTimeBar;
    private int qtdTImeBarOriginal;
    // Start is called before the first frame update
    void Start()
    {
        qtdTimeBar = sptTimeBars.Length -1;
        imgTimeBar.sprite = sptTimeBars[qtdTimeBar];
        qtdTImeBarOriginal = qtdTimeBar;
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
}