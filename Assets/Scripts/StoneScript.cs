using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class StoneScript : MonoBehaviour

{


    [SerializeField]
    GameObject Stone;
    Transform myTransform;
    float spwanTimer = 2;

    // Start is called before the first frame update

    void Start()

    {

        myTransform = GetComponent<Transform>();

    }



    // Update is called once per frame

    void Update()

    {

        spwanTimer -= Time.deltaTime;

        if (spwanTimer <= 0)

        {

            spwanTimer = 2;



            // float RandX = Random.Range(61f, 63f);

            float RandX = Random.Range(-1f, 1f);

            float RandZ = Random.Range(43.04f, 153.74f);

            //float RandY = Random.Range(1f, 5f);



            Vector3 StonePos = new Vector3(RandX, 0.2f, myTransform.transform.position.z + 3);

            //Vector3 CoinPos = new Vector3(RandX, RandY, RandZ);



            Instantiate(Stone, StonePos, Stone.transform.rotation);

        }

    }





}