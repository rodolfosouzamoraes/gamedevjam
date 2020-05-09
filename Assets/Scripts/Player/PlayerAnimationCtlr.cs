using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationCtlr : MonoBehaviour
{
    [SerializeField] Animator animator;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        PlayIdle();
    }
    public void PlayIdle(){
        animator.SetBool("run",false);
        animator.SetBool("fall",false);
        animator.SetBool("idle",true);
        animator.SetBool("death",false);
    }

    public void PlayFall(){
        animator.SetBool("run",false);
        animator.SetBool("fall",true);
        animator.SetBool("idle",false);
        animator.SetBool("death",false);
    }
    public void PlayRun(){
        animator.SetBool("run",true);
        animator.SetBool("fall",false);
        animator.SetBool("idle",false);
        animator.SetBool("death",false);
    }
    public void PlayDeath(){
        animator.SetBool("run",false);
        animator.SetBool("fall",false);
        animator.SetBool("idle",false);
        animator.SetBool("death",true);
    }
}
