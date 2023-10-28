using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMove,0, verticalMove);
        float magnitude = moveDirection.magnitude;
        magnitude = Mathf.Clamp01(magnitude);
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

        if(moveDirection != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BulletEnemy")
        {
            GameManager.health -= 1;
        }
    }
}
