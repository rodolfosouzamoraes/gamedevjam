using UnityEngine;

public class EnemySight : MonoBehaviour
{
    private EnemyMovement enemyMovement;
    private Ray ray;
    private RaycastHit hit;

    [SerializeField] private float range = 10;

    private void Start()
    {
        enemyMovement = GetComponentInParent<EnemyMovement>();
    }

    private void FixedUpdate()
    {
        ChechForPlayer();
    }

    private void ChechForPlayer()
    {
        ray.origin = transform.position;
        ray.direction = transform.forward;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, range))
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                enemyMovement.status = EnemyMovementStatus.Chase;
            }
        }
    }
}

