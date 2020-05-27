using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsPannelCtlr : MonoBehaviour
{
    [SerializeField] Sprite sptLocked;
    [SerializeField] Sprite sptOpen;
    [SerializeField] Image[] imgPadlockLevels; 

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        int count = 1;
        foreach(Image imgPadlock in imgPadlockLevels){
            //Debug.Log("Level "+count +", "+PlayerPrefs.GetInt("Level_"+count));
            if(PlayerPrefs.GetInt("Level_"+count) == 1){
                imgPadlock.sprite = sptOpen;
            }else{
                imgPadlock.sprite = sptLocked;
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
