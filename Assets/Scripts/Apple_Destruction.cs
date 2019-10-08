using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Destruction : MonoBehaviour
{
public AudioSource AudioSource;
public AudioClip AppleFail;
void OnCollisionEnter2D(Collision2D other)
{
if(other.gameObject.tag == "Player")//destroys apple after .1 sec
    {
    Destroy(gameObject, 0.1f);
    }
if(other.gameObject.tag == "Ground")// destroys apple object
    {
    AudioSource.PlayOneShot(AppleFail);
    Destroy(gameObject, 0.1f);
    }
}
}
