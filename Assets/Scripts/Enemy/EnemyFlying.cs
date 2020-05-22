using UnityEngine;

public class EnemyFlying : MonoBehaviour
{
    private Vector3 right;
    private Vector3 left;
    private Vector3 direction = Vector3.zero;
    [SerializeField] private float flyingSpeed = 1f;
    [SerializeField] private float distance = 4f;

    private void Start()
    {
        right = Vector3.forward * distance;
        left = - Vector3.forward * distance;
        direction = right;
    }

    private void Update()
    {
        Fly();
    }
    private void Fly()
    {
        //if (transform.position.z == right.z)
        //{
        //    direction = left;
        //}
        //else if (transform.position.z == left.z)
        //{
        //    direction = right;
        //}

        transform.position += direction * Time.deltaTime * flyingSpeed;
        transform.LookAt(direction);
    }
}
