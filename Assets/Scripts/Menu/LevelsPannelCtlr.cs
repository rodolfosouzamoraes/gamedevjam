using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsPannelCtlr : MonoBehaviour
{
    [SerializeField] Sprite sptLocked;
    [SerializeField] Sprite sptOpen;
    [SerializeField] ItemLevel[] itemsLevel; 

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        int count = 0;
        foreach(ItemLevel itemLevel in itemsLevel){
            if(PlayerPrefs.GetInt("Level_"+(count+1)) == 1){
                itemLevel.sptLocked.SetActive(false);
                var timer = PlayerPrefs.GetFloat("Level_"+(count+1)+"_Timer");
                var ts = TimeSpan.FromSeconds(timer);
                itemLevel.txtTimerLevel.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                itemLevel.txtTimerLevelBack.text = itemLevel.txtTimerLevel.text;
            }else{
                itemLevel.sptLocked.SetActive(true);
                itemLevel.txtTimerLevel.text = "";
                itemLevel.txtTimerLevelBack.text = "";
            }
            count++;
        }
    }
    public void LoadLevel(int index){
        if(PlayerPrefs.GetInt("Level_"+index) == 1){
            SceneManager.LoadScene(index);
        }
        
    }
}
