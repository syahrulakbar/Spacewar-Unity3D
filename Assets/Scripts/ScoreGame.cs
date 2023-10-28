using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreGame : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("virus"))
        {
            score += 1;
            scoreText.text = "Score : "+score.ToString();
            Destroy(collision.collider.gameObject);
        }
    }
}
