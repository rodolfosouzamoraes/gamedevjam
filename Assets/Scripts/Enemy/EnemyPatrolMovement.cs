using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolMovement : EnemyMovement
{
    private int index;
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private float distanceNewDestination = 0.5f;
    [SerializeField] private float walkingSpeed = 3.5f;
    [SerializeField] private float chasingSpeed = 6.5f;

    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        WalkingSpeed = walkingSpeed;
        ChasingSpeed = chasingSpeed;
        index = 0;
    }

    public override void Walk()
    {
        meshAgent.SetDestination(wayPoints[index].position);

        if (meshAgent.remainingDistance < distanceNewDestination)
        {
            index++;
            index %= wayPoints.Length;
        }
    }
}
