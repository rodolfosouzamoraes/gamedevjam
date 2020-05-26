using UnityEngine;

public class Boss : MonoBehaviour
{
    private Animator animator;
    private int index = 1;
    private float rotation;
    private bool isAttacking = false;
    private float attackTime;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float maxSecondsToAttack = 4f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rotation = transform.eulerAngles.y;
        attackTime = Random.Range(1, maxSecondsToAttack);
    }
    private void Update()
    {
        FlyAround();

        if (isAttacking)
        {
            Attack();
        }
    }

    private void FlyAround()
    {
        if (!isAttacking)
        {
            Vector3 target = new Vector3(waypoints[index].position.x, PlayerMng.Instance.transform.position.y, waypoints[index].position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if (HasReachedWaypoint())
            {
                index++;
                index %= waypoints.Length;
                rotation += 90;
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, rotation, transform.eulerAngles.z);
            }
        }
    }

    private void CheckAttackCountdown()
    {
        if (!isAttacking)
        {
            attackTime = -Time.deltaTime;

            if (attackTime <= 0)
            {
                isAttacking = true;
            }
        }
    }

    private void Attack()
    {

    }

    private bool HasReachedWaypoint()
    {
        return Mathf.Approximately(transform.position.x, waypoints[index].position.x) && Mathf.Approximately(transform.position.z, waypoints[index].position.z);
    }
}
