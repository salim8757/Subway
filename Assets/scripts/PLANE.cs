using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLANE : MonoBehaviour
{

    //public Transform plane1;
    public Transform plane2;

    Vector3 orginslposition;

    float Timer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //plane2 = GetComponent<Transform>();
        orginslposition = transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = orginslposition;

        Timer -= Time.deltaTime;

        if(Timer<=0)
        {
            plane2.transform.position = orginslposition;

            gameObject.SetActive(false);
          

        }





    }
}
