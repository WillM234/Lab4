using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Apple_Creation : MonoBehaviour
{
public int Apple_Timer = 0;
public int Max_Time;
public GameObject Apple_PreFab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
    Apple_Timer ++;
if(Apple_Timer >= Max_Time)
    {
    Instantiate(Apple_PreFab, new Vector3(Random.Range(-8f,8f),4.5f,0f),Quaternion.identity);
    Apple_Timer = 0;
    }
    }
IEnumerator AddTime()
{
while(true)
{
yield return new
WaitForSeconds(1);
Apple_Timer ++;
}
}
}
