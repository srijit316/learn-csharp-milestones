using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public float speed = 15f;

    void Start()
    {
        // Make projectile move forward automatically
        GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }
}
