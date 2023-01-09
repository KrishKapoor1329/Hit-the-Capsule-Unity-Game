using UnityEngine;
using System.Collections;

public class RigidBody : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Let the rigidbody take control and detect collisions.
    void EnableRagdoll()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    // Let animation control the rigidbody and ignore collisions.
    void DisableRagdoll()
    {
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }
}