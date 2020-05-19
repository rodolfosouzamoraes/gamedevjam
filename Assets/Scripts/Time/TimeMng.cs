using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por parar o tempo
/// </summary>
public class TimeMng : MonoBehaviour
{
    public static TimeMng Instance;
    void Awake()
    {
        if(Instance==null){
            Instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    [SerializeField] public float timeScale;
    [SerializeField] public float timeWait;

    Coroutine coroutine;
    public bool isTimeActived;
    /// <summary>
    /// Inicia o processo de parar o tempo
    /// </summary>
    public void StopTime(){
        AudioManager.Instance.Play(Audio.Effect, Clip.SlowMotion, false);
        isTimeActived = true;
        coroutine = StartCoroutine(StopTimeSlowly());
    }
    /// <summary>
    /// Coroutine para parar o tempo lentamente
    /// </summary>
    /// <returns></returns>
    IEnumerator StopTimeSlowly(){
        while(true){
            yield return new WaitForSeconds(0.1f);
            timeScale -=0.1f;
            if(timeScale<=0){
                timeScale = 0;
                CanvasMainMng.HourglassPannel.InitTime((int)timeWait);
                Invoke("StartTime",timeWait);
                StopCoroutine(coroutine);
            }
        }
    }
    /// <summary>
    /// Inicia o processo de startar o tempo
    /// </summary>
    public void StartTime(){
        AudioManager.Instance.Play(Audio.Effect, Clip.SlowMotionRevert, false);
        coroutine = StartCoroutine(StartTimeSlowly());
    }
    /// <summary>
    /// Coroutine starta o tempo lentamente
    /// </summary>
    /// <returns></returns>
    IEnumerator StartTimeSlowly(){
        while(true){
            yield return new WaitForSeconds(0.1f);
            timeScale +=0.1f;
            if(timeScale>=1){
                isTimeActived = false;
                timeScale = 1;
                CanvasMainMng.HourglassPannel.ActiveOrDesactiveElements(false);
                StopCoroutine(coroutine);
            }
        }
    }
}
