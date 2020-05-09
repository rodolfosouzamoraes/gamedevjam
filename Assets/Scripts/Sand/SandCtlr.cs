using UnityEngine;

public class SandCtlr : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime /** TimeMng.Instance.timeScale*/);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Ativar game over
    }
}
