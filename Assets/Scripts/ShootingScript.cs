using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject bullet;
    public float speed;

    [SerializeField] private AudioSource shootSoundEffect;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       // if(Input.GetButtonDown("Fire1") && Time.timeScale !=0)
       // {
       //     shootSoundEffect.Play();
     //       Shoot();
      //  }
    }

    void Shoot()
    {
        GameObject cb = Instantiate(bullet, spawnPosition.position, bullet.transform.rotation);
        Rigidbody rb = cb.GetComponent<Rigidbody>();
        rb.AddForce(spawnPosition.forward * speed, ForceMode.Impulse);
        Destroy(cb, 1f);
    }

    public void ShootButton()
    {
        if(Time.timeScale != 0)
        {
         shootSoundEffect.Play();
         GameObject cb = Instantiate(bullet, spawnPosition.position, bullet.transform.rotation);
         Rigidbody rb = cb.GetComponent<Rigidbody>();
         rb.AddForce(spawnPosition.forward * speed, ForceMode.Impulse);
         Destroy(cb, 1f);
        }
    }
}
