using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPannelCtlr : MonoBehaviour
{
    [SerializeField] SoundVolumeCtlr soundVolume;
    [SerializeField] SensibilityMouseCtlr sensibilityMouse;
    
    public void SetSlidersVolume(){
        soundVolume.SetScrollbarValues();
    }

    public void SetSensibilityMouse(){
        sensibilityMouse.SetScrollbarValue();
    }
}
