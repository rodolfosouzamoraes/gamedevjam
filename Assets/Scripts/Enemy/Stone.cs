using UnityEngine;

public class Stone : MonoBehaviour
{
    private BossShooting bossShooting;
    private Rigidbody rb;
    private float timeAux;
    private bool isReadyToCountdown = false;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float timeToDisable = 4f;

    private void Awake()
    {
        bossShooting = transform.root.GetComponent<BossShooting>();
        rb = GetComponent<Rigidbody>();
        timeAux = timeToDisable;
    }

    private void OnEnable()
    {
        isReadyToCountdown = true;
        Shoot();
    }

    private void OnDisable()
    {
        bossShooting.ReturnStoneToAim(gameObject);
        rb.velocity = Vector3.zero;
    }

    private void Update()
    {
        if(isReadyToCountdown)
        {
            CheckCountdown();
        }
    }

    public void Shoot()
    {
        rb.AddForce(transform.parent.forward * speed, ForceMode.Impulse);
    }

    private void CheckCountdown()
    {
        timeToDisable -= Time.deltaTime;

        if(timeToDisable <= 0)
        {
            timeToDisable = timeAux;
            isReadyToCountdown = false;
            gameObject.SetActive(false);
        }
    }

}
