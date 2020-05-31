using UnityEngine.UI;
using UnityEngine;

public class SoundVolumeCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar soundEffects;
    [SerializeField] private Scrollbar music;

    public void SetScrollbarValues()
    {
        soundEffects.value = DBMng.EffectVolume();
        music.value = DBMng.MusicVolume();
    }

    public void SaveSound()
    {
        DBMng.SetEffectVolume(soundEffects.value);
        DBMng.SetMusicVolume(music.value);
        AudioManager.Instance.ChangeVolume(Audio.Environment, music.value);
        
    }
}
