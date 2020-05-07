using UnityEngine.UI;
using UnityEngine;

public class SoundVolumeCtlr : MonoBehaviour
{
    [SerializeField] private Scrollbar globalSound;
    [SerializeField] private Scrollbar effectsSound;

    private void Awake()
    {
        SetScrollbarValues();
    }

    private void SetScrollbarValues()
    {
        globalSound.value = PlayerPrefs.GetFloat("GlobalSound");
        effectsSound.value = PlayerPrefs.GetFloat("EffectsSound");
    }

    public void SaveSound()
    {
        PlayerPrefs.SetFloat("GlobalSound", globalSound.value);
        PlayerPrefs.SetFloat("EffectsSound", effectsSound.value);
        AudioListener.volume = PlayerPrefs.GetFloat("GlobalSound");
    }
}
