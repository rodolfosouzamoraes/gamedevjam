using UnityEngine;
public class EnemyArea : MonoBehaviour
{
    [SerializeField] private EnemyMovement enemyMovement;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            enemyMovement.status = EnemyMovementStatus.Walk;
        }
    }
}
