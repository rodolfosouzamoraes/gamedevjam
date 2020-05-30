using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalItemCtlr : MonoBehaviour
{
    [SerializeField] int score;
    void OnTriggerStay(Collider other)
    {
        CanvasMainMng.TimeBarPannel.IncreaseCristal(score);
        AudioManager.Instance.Play(Audio.Effect,Clip.Crystal,false);
        Destroy(gameObject);  
    }
}
