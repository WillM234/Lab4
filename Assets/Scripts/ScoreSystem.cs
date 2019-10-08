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
//Audio Stuff
public AudioSource AudioSource;
public AudioClip GetApple;
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
    
    if(other.gameObject.tag == "Apple")//adds score,audio and emits particle on apple collision
        {
        Score += 1; 
        AudioSource.PlayOneShot(GetApple);
        AppleCollectedPS.Emit(200);
        }
    }
}
