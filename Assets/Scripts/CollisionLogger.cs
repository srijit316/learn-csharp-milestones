using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Hit object: {collision.gameObject.name}");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Entered trigger: {other.gameObject.name}");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log($"Exited trigger: {other.gameObject.name}");
    }
}
