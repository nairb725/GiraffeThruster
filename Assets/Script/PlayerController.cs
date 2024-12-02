using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 forceDirection;

    [SerializeField]
    private float forceDuration;

    [SerializeField]
    private float cooldownDuration;

    private bool isGrounded = false;
    private bool isCooldown = false;

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !isCooldown)
        {
            ApplyForce();
        }
    }

    private void ApplyForce()
    {
        isCooldown = true;

        float elapsedTime = 0f;

        while (elapsedTime < forceDuration)
        {
            rb.AddForce(forceDirection, ForceMode.Impulse);
            elapsedTime += Time.deltaTime;
        }
        isCooldown = false;
    }

}