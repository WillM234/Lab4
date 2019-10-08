using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
public int Score;
public Text countUp;
public GameObject Apple;
public ParticleSystem AppleCollectedPS;
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
    
    if(other.gameObject.tag == "Apple")
        {
        Score += 1; 
        AppleCollectedPS.Emit(200);
        }
    }
}
