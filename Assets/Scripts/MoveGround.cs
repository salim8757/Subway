using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveGround : MonoBehaviour

{
    float OriginalPos = 35f;
    //private float Speed = 10;

    float accelerationTime = 60;

    float minSpeed;

    float time;

    float currentSpeed = 10f;

    float maxSpeed = 100f;


    // Start is called before the first frame update

    void Start()

    {
        minSpeed = currentSpeed;

        time = 0;
    }



    // Update is called once per frame

    void Update()

    {

        transform.Translate(0, 0, Time.deltaTime * -currentSpeed);

        if (transform.position.z <= -66)

        {

            if (gameObject.tag == "plane")

            {

                transform.position = new Vector3(transform.position.x, transform.position.y, OriginalPos);

            }



            if (gameObject.tag == "coin")

            {

                Destroy(gameObject);

                print("coin Destroyed");

            }

        }

        increaseSpead();

    }


    void increaseSpead()

    {



        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);

        time += Time.deltaTime;

       // print("My speed:" + currentSpeed);

    }

}

