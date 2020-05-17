using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TimerPostProcessingEffectCtlr : MonoBehaviour
{
    [SerializeField] PostProcessVolume postProcessVolume;

    // Update is called once per frame
    void Update()
    {
        postProcessVolume.weight = (TimeMng.Instance.timeScale - 1)*-1;
    }
}
