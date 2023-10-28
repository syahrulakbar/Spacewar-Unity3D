using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    // Awake dimulai lebih dulu daripada start
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Moving();
    }

    void Moving()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * move * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
