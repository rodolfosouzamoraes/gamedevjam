using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private float timeAux;
    private NavMeshAgent meshAgent;
    private int index;
    private bool isStopped = false;

    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private float distanceToSetNewDestination = 0.5f;
    [SerializeField] private float walkingSpeed = 3.5f;
    [SerializeField] private float chasingSpeed = 6.5f;
    [SerializeField] private float stopTime = 3f;

    public static float CurrentSpeed { get; private set; }

    void Start()
    {
        timeAux = stopTime;
        meshAgent = GetComponent<NavMeshAgent>();
        index = 0;
    }

    void Update()
    {
        if (isStopped)
        {
            Stop();
        }
        else
        {
            Move();
        }

    }

    private void Move()
    {
        SetSpeed(walkingSpeed);
        meshAgent.SetDestination(wayPoints[index].position);

        if (meshAgent.remainingDistance < distanceToSetNewDestination)
        {
            index++;
            index %= wayPoints.Length;
            isStopped = true;
        }
    }

    private void Stop()
    {
        SetSpeed(0);
        stopTime -= Time.deltaTime;
        if(stopTime <= 0)
        {
            stopTime = timeAux;
            isStopped = false;
        }
    }

    private void Chase(Transform player)
    {
        SetSpeed(chasingSpeed);
        meshAgent.SetDestination(player.position);
    }

    private void SetSpeed(float value)
    {
        meshAgent.speed = value /** TimeMng.Instance.timeScale*/;
        CurrentSpeed = meshAgent.speed;
    }
}
