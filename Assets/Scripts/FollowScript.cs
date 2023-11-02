using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform targetObj;


    [SerializeField] private float timer = 2;
    private float bulletTime;

    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;


    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 1 * Time.deltaTime);
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;
        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed, ForceMode.Impulse);
        Destroy(bulletObj, 1f);

    }




}
