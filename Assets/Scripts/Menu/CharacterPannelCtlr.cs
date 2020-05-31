using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPannelCtlr : MonoBehaviour
{
    [SerializeField] Text txtCristalScoreBack;
    [SerializeField] Text txtCristalScore;

    public int cristalScore;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        UpdateCristalScore();
    }

    public void UpdateCristalScore(){
        cristalScore = DBMng.CrystalScore();
        txtCristalScoreBack.text = "x"+cristalScore;
        txtCristalScore.text = "x"+cristalScore;
    }
}
