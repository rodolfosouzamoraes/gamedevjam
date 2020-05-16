using UnityEngine;

public class SandCtlr : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        if(!CanvasMainMng.Instance.isGameOver){
            Move();
        }
        
    }

    private void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime * TimeMng.Instance.timeScale);
    }

    private void OnTriggerEnter(Collider other)
    {
        CanvasMainMng.Instance.isGameOver = true;
        other.gameObject.SetActive(false);
        CanvasMainMng.Instance.ShowGameOverPannel();
    }
}
