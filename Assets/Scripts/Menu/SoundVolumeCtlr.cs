using UnityEngine.UI;
using UnityEngine;

public class SoundVolumeCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar soundEffects;
    [SerializeField] private Scrollbar music;

    public void SetScrollbarValues()
    {
        soundEffects.value = PlayerPrefs.GetFloat("EffectsSound");
        music.value = PlayerPrefs.GetFloat("Music");
    }

    public void SaveSound()
    {
        PlayerPrefs.SetFloat("EffectsSound", soundEffects.value);
        PlayerPrefs.SetFloat("Music", music.value);
        AudioManager.Instance.ChangeVolume(Audio.Environment, music.value);
        
    }
}
