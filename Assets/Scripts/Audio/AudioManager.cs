using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    [SerializeField] private AudioSource[] sources;
    [SerializeField] private AudioClip[] clips;
    public static AudioManager Instance 
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("AudioManager is not instantiated.");
            }

            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        Play(Audio.Soundtrack, Clip.Music, true);
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
}
