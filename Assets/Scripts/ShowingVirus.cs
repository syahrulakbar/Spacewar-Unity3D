using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingVirus : MonoBehaviour
{
    [SerializeField] public GameObject enemy;
    public float timeMin, timeMax;
    public float positionMin, positionMax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowVirus()
    {
        Instantiate(enemy, transform.position  + Vector3.right * Random.Range(positionMin, positionMax), 
            Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        StartCoroutine(ShowVirus());
    }
}
