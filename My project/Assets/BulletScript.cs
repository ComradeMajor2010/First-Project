using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * 1100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
