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
        if(DBMng.StatusCharacter(idCharacter)==0){
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
            DBMng.SetCrystalScore(newCristalScore);
            DBMng.UnlockCharacter(idCharacter);
            bottom.SetActive(false);
            MainMenuMng.CharacterPannel.UpdateCristalScore();
        }
    }

    public void SelectCharacter(PannelCtlr pannel){
        if(DBMng.StatusCharacter(idCharacter)==1){
            DBMng.SelectCharacter(idCharacter);
            MainMenuMng.Instance.ShowPannel(pannel);
        }
    }
}
