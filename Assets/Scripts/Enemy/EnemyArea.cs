using UnityEngine;
public class EnemyArea : MonoBehaviour
{
    [SerializeField] private EnemyMovement enemyMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemyMovement.status = EnemyMovementStatus.Chase;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemyMovement.status = EnemyMovementStatus.Walk;
        }
    }
}
