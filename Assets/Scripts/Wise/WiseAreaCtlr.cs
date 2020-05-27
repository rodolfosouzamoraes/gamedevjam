using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiseAreaCtlr : MonoBehaviour
{
    [SerializeField] string message;
    [SerializeField] Animator animator;

    /// <summary>
    /// OnTriggerStay is called once per frame for every Collider other
    /// that is touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player")){
            TalkingAnimator();
            CanvasMainMng.Instance.ShowTutorial(message);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            IdleAnimator();
            CanvasMainMng.Instance.HideTutorial();
        }
    }

    void TalkingAnimator(){
        animator.SetBool("Talking", true);
        animator.SetBool("Idle", false);
    }

    void IdleAnimator(){
        animator.SetBool("Talking", false);
        animator.SetBool("Idle", true);
    }
}
