using UnityEngine;
using UnityEngine.AI;

public class EnemyHunterMovement : EnemyMovement
{
    private Vector3 randomPosition;
    [SerializeField] private float walkRadius = 8f;
    [SerializeField] private float distanceNewDestination = 0.5f;
    [SerializeField] private float walkingSpeed = 3.5f;
    [SerializeField] private float chasingSpeed = 6.5f;

    private void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        WalkingSpeed = walkingSpeed;
        ChasingSpeed = chasingSpeed;

        randomPosition = GetRandomPosition();
    }

    public override void Walk()
    {
        if (meshAgent.remainingDistance <= distanceNewDestination)
        {
            randomPosition = GetRandomPosition();
        }

        meshAgent.SetDestination(randomPosition);
    }

    private Vector3 GetRandomPosition()
    {
        return transform.position + Random.insideUnitSphere * walkRadius;
    }
}
