using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float jetpackForce = 10f;
    [SerializeField]
    private float jetpackDuration = 3f;
    [SerializeField]
    private float rechargeTime = 2f;
    [SerializeField]
    private float rotationSpeed = 200f;
    [SerializeField]
    private GameObject Jetpack;
    [SerializeField]
    private GameObject PressE;

    private float jetpackTimer = 0f;
    private float rechargeTimer = 0f;
    private bool isUsingJetpack = false;
    private bool canMove = false;
    private int ePressCount = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jetpack.SetActive(false);
        PressE.SetActive(true);
    }

    void Update()
    {
        if (canMove)
        {
            HandleRotation();
            HandleJetpack();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ePressCount++;

            if (ePressCount == 6)
            {
                Jetpack.SetActive(true);
            }

            if (ePressCount >= 8)
            {
                canMove = true;
                PressE.SetActive(false);
            }
        }
    }

    private void HandleJetpack()
    {
        if (!isUsingJetpack)
        {
            rechargeTimer = Mathf.Min(rechargeTimer + Time.deltaTime, rechargeTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && rechargeTimer >= rechargeTime)
        {
            isUsingJetpack = true;
            jetpackTimer = 0f;
            rechargeTimer = 0f;
        }

        if (isUsingJetpack)
        {
            if (jetpackTimer < jetpackDuration)
            {
                rb.AddForce(transform.up * jetpackForce);
                jetpackTimer += Time.deltaTime;
            }
            else
            {
                isUsingJetpack = false;
            }
        }
    }

    private void HandleRotation()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(-rotation, 0, 0);
    }
}
