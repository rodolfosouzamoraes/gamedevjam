using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationCtlr : MonoBehaviour
{
    [SerializeField] Animator[] animator;
    [SerializeField] GameObject[] bodys;
    int idBody = 0;
    void Start()
    {
        idBody = PlayerPrefs.GetInt("IdBodyChosen");
        foreach(GameObject body in bodys){
            body.SetActive(false);
        }
        bodys[idBody].SetActive(true);
        
        PlayIdle();
    }
    public void PlayIdle(){
        animator[idBody].SetBool("run",false);
        animator[idBody].SetBool("fall",false);
        animator[idBody].SetBool("idle",true);
        animator[idBody].SetBool("death",false);
    }

    public void PlayFall(){
        animator[idBody].SetBool("run",false);
        animator[idBody].SetBool("fall",true);
        animator[idBody].SetBool("idle",false);
        animator[idBody].SetBool("death",false);
    }
    public void PlayRun(){
        animator[idBody].SetBool("run",true);
        animator[idBody].SetBool("fall",false);
        animator[idBody].SetBool("idle",false);
        animator[idBody].SetBool("death",false);
    }
    public void PlayDeath(){
        animator[idBody].SetBool("run",false);
        animator[idBody].SetBool("fall",false);
        animator[idBody].SetBool("idle",false);
        animator[idBody].SetBool("death",true);
    }
}
