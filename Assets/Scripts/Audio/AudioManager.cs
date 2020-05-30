using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;


    [SerializeField] private AudioClip[] clips;
    private AudioSource[] sources;
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("AudioManager is not instantiated.");
            }

            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        sources = GetComponents<AudioSource>();

        Init();

        SetVolumes();
    }
    public void SetVolumes(){
        ChangeVolume(Audio.Environment, PlayerPrefs.GetFloat("Music"));
        ChangeVolume(Audio.Player, PlayerPrefs.GetFloat("EffectsSound"));
        ChangeVolume(Audio.Boss, PlayerPrefs.GetFloat("EffectsSound"));
        ChangeVolume(Audio.Effect, PlayerPrefs.GetFloat("EffectsSound"));
        ChangeVolume(Audio.EndGame, PlayerPrefs.GetFloat("EffectsSound"));
    }

    private void Init()
    {
        if (SceneManager.GetActiveScene().name == "Level_10")
        {
            Play(Audio.Environment, Clip.BossMusic, true);
        }
        else
        {
            Play(Audio.Environment, Clip.Music, true);
        }
    }

    public void Play(Audio audio, Clip clip, bool isLooping)
    {
        sources[(int)audio].clip = clips[(int)clip];
        sources[(int)audio].loop = isLooping;
        sources[(int)audio].Play();
    }

    public void Stop(Audio audio)
    {
        sources[(int)audio].Stop();
    }

    public void ChangeVolume(Audio audio, float volume)
    {
        sources[(int)audio].volume = volume;
    }

    public void LowerVolumes()
    {
        StartCoroutine(LowerVolume(Audio.Environment));
        StartCoroutine(LowerVolume(Audio.Effect));
        StartCoroutine(LowerVolume(Audio.Player));
    }

    public IEnumerator LowerVolume(Audio audio)
    {
        while (sources[(int)audio].volume != 0)
        {
            sources[(int)audio].volume -= 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
