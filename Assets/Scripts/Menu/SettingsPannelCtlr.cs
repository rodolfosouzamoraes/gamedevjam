using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPannelCtlr : MonoBehaviour
{
    [SerializeField] SoundVolumeCtlr soundVolume;
    
    public void SetSlidersVolume(){
        soundVolume.SetScrollbarValues();
    }
}
