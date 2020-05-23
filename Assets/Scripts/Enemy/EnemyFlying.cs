using UnityEngine;

public class EnemyFlying : MonoBehaviour
{
    private Animator animator;
    private Vector3 posRight;
    private Vector3 posLeft;
    private Vector3 target;
    [SerializeField] private float flyingSpeed = 5f;
    [SerializeField] private float distance = 4f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        posRight = transform.position + (transform.forward * distance);
        posLeft = transform.position + (-transform.forward * distance);
        target = posRight;
    }

    private void Update()
    {
        Fly();
        animator.speed = TimeMng.Instance.timeScale;
    }
    private void Fly()
    {
        if (transform.position == posRight)
        {
            target = posLeft;
            transform.forward *= -1;
        }
        else if (transform.position == posLeft)
        {
            target = posRight;
            transform.forward *= -1;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * flyingSpeed * TimeMng.Instance.timeScale);
    }
}
