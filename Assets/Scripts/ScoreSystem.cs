using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
public int Score;
public Text countUp;
public GameObject Apple;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
    countUp.text = ("Score: " + Score);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
    if(other.gameObject.tag == "Ground")
        {
        Score = 0;
    Destroy(gameObject);
        }
    if(other.gameObject.tag == "Player")
        {
        Score += 1; 
    Destroy(gameObject,0.5f);
        }
    }
}
