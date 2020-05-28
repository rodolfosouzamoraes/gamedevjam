using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterItemCtlr : MonoBehaviour
{
    [SerializeField] Text txtPriceItemBack;
    [SerializeField] Text txtPriceItem;
    [SerializeField] GameObject bottom;
    [SerializeField] int price;
    [SerializeField] int idCharacter;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if(PlayerPrefs.GetInt("IdBodyChosen_"+idCharacter)==0){
            txtPriceItemBack.text = "x"+price;
            txtPriceItem.text = "x"+price;
        }
        else{
            bottom.SetActive(false);
        }
        
    }

    public void BuyCharacter(){
        if(MainMenuMng.CharacterPannel.cristalScore>=price){
            int newCristalScore = MainMenuMng.CharacterPannel.cristalScore-price;
            PlayerPrefs.SetInt("CristalScore",newCristalScore);
            PlayerPrefs.SetInt("IdBodyChosen_"+idCharacter,1);
            bottom.SetActive(false);
            MainMenuMng.CharacterPannel.UpdateCristalScore();
        }
    }

    public void SelectCharacter(PannelCtlr pannel){
        if(PlayerPrefs.GetInt("IdBodyChosen_"+idCharacter)==1){
            PlayerPrefs.SetInt("IdBodyChosen",idCharacter);
            MainMenuMng.Instance.ShowPannel(pannel);
        }
    }
}
