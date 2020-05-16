using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyMovement : MonoBehaviour
{
    protected NavMeshAgent meshAgent;
    public float WalkingSpeed { get; protected set; }
    public float ChasingSpeed { get; protected set; }
    public float CurrentSpeed { get; protected set; }
    public EnemyMovementStatus status { get; set; }

    private void Start()
    {
        status = EnemyMovementStatus.Walk;
    }

    private void Update()
    {
        switch (status)
        {
            case EnemyMovementStatus.Walk:
                SetSpeed(WalkingSpeed);
                Walk();
                break;

            case EnemyMovementStatus.Chase:
                SetSpeed(ChasingSpeed);
                Chase();
                break;
        }
    }

    public abstract void Walk();
    public void Chase()
    {
        if(meshAgent.enabled){
            meshAgent.SetDestination(PlayerMng.Instance.transform.position);
        }
    }

    public void SetSpeed(float value)
    {
        meshAgent.speed = value * TimeMng.Instance.timeScale;
        if(TimeMng.Instance.timeScale>0){
            meshAgent.enabled = true;   
        }
        else{
            meshAgent.enabled = false; 
        }
        CurrentSpeed = meshAgent.speed;
    }
}
