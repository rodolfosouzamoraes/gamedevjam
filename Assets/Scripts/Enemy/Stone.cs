using UnityEngine;

public class Stone : MonoBehaviour
{
    private BossShooting bossShooting;
    private Rigidbody rb;
    private float timeAux;
    private bool isReadyToCountdown = false;
    private bool isShooting = false;
    private Vector3 shootingDirection;
    [SerializeField] private float force = 20f;
    [SerializeField] private float timeToDisable = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        timeAux = timeToDisable;
    }

    private void OnEnable()
    {
        isReadyToCountdown = true;
        shootingDirection = GameObject.FindGameObjectWithTag("Boss").transform.forward;
        isShooting = true;
    }

    private void OnDisable()
    {
        timeToDisable = timeAux;
        isReadyToCountdown = false;
        isShooting = false;
        rb.velocity = Vector3.zero;
    }

    private void Update()
    {
        if (isReadyToCountdown)
        {
            CheckCountdown();
        }

        if (isShooting)
        {
            CheckTimeScale();
            Shoot();
        }
    }

    private void CheckTimeScale()
    {
        if (TimeMng.Instance.timeScale > 0)
        {
            rb.useGravity = true;
            rb.freezeRotation = false;
        }
        else
        {
            rb.useGravity = false;
            rb.freezeRotation = true;
        }
    }

    public void Shoot()
    {
        rb.velocity = shootingDirection * force * TimeMng.Instance.timeScale;
    }

    private void CheckCountdown()
    {
        if (TimeMng.Instance.timeScale > 0)
        {
            timeToDisable -= Time.deltaTime;

            if (timeToDisable <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
