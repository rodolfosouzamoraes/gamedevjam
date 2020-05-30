using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WinPannelCtlr : MonoBehaviour
{
    [SerializeField] Text txtTimerNowBack;
    [SerializeField] Text txtTimerNow;
    [SerializeField] Text txtTimerAfterBack;
    [SerializeField] Text txtTimerAfter;
    [SerializeField] Text txtCrystalBack;
    [SerializeField] Text txtCrystal;
    public void NextLevel(){
        SceneManager.LoadScene(CanvasMainMng.indexScene+1);
    }
    public void ExitLevel(){
        CanvasMainMng.Instance.ExitLevel();
    }

    public void SetTimerText(float timerNow, float timerAfter){
        txtTimerNowBack.text = ConvertTimer(timerNow);
        txtTimerNow.text = txtTimerNowBack.text;
        txtTimerAfterBack.text = ConvertTimer(timerAfter);
        txtTimerAfter.text = txtTimerAfterBack.text;

    }

    public void SetCrystalText(float scoreCrystal){
        txtCrystalBack.text = "x"+scoreCrystal;
        txtCrystal.text = "x"+scoreCrystal;

    }

    string ConvertTimer(float _timer){
        var ts = TimeSpan.FromSeconds(_timer);
        var timer = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        return timer;
    }
}
