using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDown : MonoBehaviour
{
public int Score;
public Text countDown;
void Update()
{
if(Score <= 0)
{
Score = 0; 
}
}
 void OnCollisionEnter2D(Collision2D other)
 {
 if(other.gameObject.tag == "Apple")//decreases score by 1
    {
    Score -= 1;
    }
 }
}

