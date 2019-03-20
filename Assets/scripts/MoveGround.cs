using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    float OriginalPos = 135f;
    //float OriginalPos = 101f;
    private float Speed = 80;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * -Speed);

        if (transform.position.z <= -66)
        {
             if (gameObject.tag == "plana")
            {
            transform.position = new Vector3(transform.position.x, transform.position.y, OriginalPos);
             }

           if (gameObject.tag == "coin")
           {
                Destroy(gameObject);
               print("coin Destroyed");

            }
        }
    }
}




