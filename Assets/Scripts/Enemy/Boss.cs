using UnityEngine;

public class Boss : MonoBehaviour
{
    private BossShooting bossShooting;
    private Animator animator;
    private int index = 1;
    private float rotation;
    private bool isAttacking = false;
    private float timeAux;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float timeToAttack = 4f;

    private void Start()
    {
        bossShooting = GetComponent<BossShooting>();
        animator = GetComponentInChildren<Animator>();
        rotation = transform.eulerAngles.y;
        timeAux = timeToAttack;
    }
    private void Update()
    {
        FlyAround();
        CheckAttackCountdown();
    }

    private void FlyAround()
    {
        Vector3 target = new Vector3(waypoints[index].position.x, PlayerMng.Instance.transform.position.y + 5f, waypoints[index].position.z); ;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (HasReachedWaypoint())
        {
            index++;
            index %= waypoints.Length;
            rotation += 90;
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, rotation, transform.eulerAngles.z);
        }
    }

    private void CheckAttackCountdown()
    {
        timeToAttack -= Time.deltaTime;

        if (timeToAttack <= 0)
        {
            Attack();
        }
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
        AudioManager.Instance.Play(Audio.Boss, Clip.Eagle, false);
        bossShooting.Shoot();
        timeToAttack = timeAux;
    }

    private bool HasReachedWaypoint()
    {
        return Mathf.Approximately(transform.position.x, waypoints[index].position.x) && Mathf.Approximately(transform.position.z, waypoints[index].position.z);
    }
}
