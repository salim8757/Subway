using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{


    [SerializeField]
    GameObject Cube;
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
            spwanTimer =2;

            // float RandX = Random.Range(61f, 63f);
            float RandX = Random.Range(-9f, 9f);
            float RandZ = Random.Range(43.04f, 153.74f);
            float RandY = Random.Range(1f, 5f);

            Vector3 CoinPos = new Vector3(RandX, RandY, myTransform.transform.position.z + 3);
            //Vector3 CoinPos = new Vector3(RandX, RandY, RandZ);

            Instantiate(Cube, CoinPos, Cube.transform.rotation);
        }
    }


}
