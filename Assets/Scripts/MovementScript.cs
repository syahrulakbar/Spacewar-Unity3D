using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public FixedJoystick analog;
    [SerializeField] private AudioSource gameOverSoundEffect;


    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMove = analog.Horizontal;

        float verticalMove = analog.Vertical;



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

        if (GameManager.health == 0)
        {
            //gameOverSoundEffect.Play();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BulletEnemy")
        {
            GameManager.health -= 1;

            if(GameManager.health == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
