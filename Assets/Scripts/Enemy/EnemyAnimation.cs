using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetInteger("Speed", (int)EnemyMovement.CurrentSpeed /** (int)TimeMng.Instance.timeScale*/);
    }
}
