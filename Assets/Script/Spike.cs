using UnityEngine;

public class Spike : MonoBehaviour
{
    public string girafeTag = "Girafe";
    public Vector3 teleportPosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(girafeTag))
        {
            collision.gameObject.transform.position = teleportPosition;
            collision.gameObject.transform.rotation = Quaternion.Euler(0, 270, 0);
        }
    }
}
