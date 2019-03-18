using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseSpeedScript : MonoBehaviour
{

     float accelerationTime = 60;
     float minSpeed;
     float time;
    float currentSpeed = 0f;
    float maxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        minSpeed = currentSpeed;
        time = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        increaseSpead();
        
    }


    void increaseSpead()
    {

        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
        time += Time.deltaTime;
        print("My speed:" + currentSpeed);
    }
}
