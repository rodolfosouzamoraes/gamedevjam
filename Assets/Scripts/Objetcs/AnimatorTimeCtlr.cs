using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTimeCtlr : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void Update()
    {
        animator.speed = TimeMng.Instance.timeScale;
    }
}
