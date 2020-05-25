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
        rotation = transform.rotation.y;
        attackTime = Random.Range(1, maxSecondsToAttack);
    }
    private void Update()
    {
        UpdateHeight();
        FlyAround();

        if(isAttacking)
        {
            Attack();
        }
    }

    private void UpdateHeight()
    {
        foreach (var waypoint in waypoints)
        {
            waypoint.position = new Vector3(waypoint.position.x, PlayerMng.Instance.transform.position.y, waypoint.position.z);
        }
    }

    private void FlyAround()
    {
        if (!isAttacking)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[index].position, speed * Time.deltaTime);

            if (transform.position == waypoints[index].position)
            {
                index++;
                index %= waypoints.Length;
                rotation += 90;
                transform.rotation = Quaternion.Euler(transform.rotation.x, rotation, transform.rotation.z);
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
}
