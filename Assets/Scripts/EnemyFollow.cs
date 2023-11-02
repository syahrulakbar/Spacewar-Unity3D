using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private AudioSource shootSoundEffect;



    private NavMeshAgent enemy;
    public Transform player;

    [SerializeField] private float timer = 3;
    private float bulletTime;

    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        //enemy.destination = player.position;
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
       bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;
        bulletTime = timer;

        shootSoundEffect.Play();
        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed, ForceMode.Impulse);

        Destroy(bulletObj, 1f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);

            ScoreManager.scoreCount +=1;
        }
    }

  

}
