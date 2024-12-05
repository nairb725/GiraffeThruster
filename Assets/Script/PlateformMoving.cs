using UnityEngine;

public class PlateformeMoving : MonoBehaviour
{
    [SerializeField]
    private Vector3 conveyorForce = new Vector3(2f, 0f, 0f);
    [SerializeField]
    private bool affectRigidbody = true;
    [SerializeField]
    private bool affectTransform = false;

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;

        if (affectRigidbody && rb != null)
        {
            rb.velocity = new Vector3(conveyorForce.x, rb.velocity.y, conveyorForce.z);
        }
        else if (affectTransform)
        {
            collision.transform.position += conveyorForce * Time.deltaTime;
        }
    }
}
