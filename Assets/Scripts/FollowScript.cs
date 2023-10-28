using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform targetObj;


    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 1 * Time.deltaTime);
    }

 

  
}
