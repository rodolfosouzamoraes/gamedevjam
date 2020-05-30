using UnityEngine.UI;
using UnityEngine;

public class SoundVolumeCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar soundEffects;
    [SerializeField] private Scrollbar music;

    private void Awake()
    {
        SetScrollbarValues();
    }

    private void SetScrollbarValues()
    {
        soundEffects.value = PlayerPrefs.GetFloat("EffectsSound");
        music.value = PlayerPrefs.GetFloat("Music");
    }

    public void SaveSound()
    {
        PlayerPrefs.SetFloat("EffectsSound", soundEffects.value);
        PlayerPrefs.SetFloat("Music", music.value);
    }
}
