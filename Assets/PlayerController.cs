using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject Coin;

    float spwanTimer = 1;

    List<GameObject> allCoins;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spwanTimer -= Time.deltaTime;
        if (spwanTimer <= 0)
        {
            spwanTimer = 1;
            allCoins.Add(Instantiate(Coin, new Vector3(Random.Range(-0.9f, 0.9f), 0.5f, Random.Range(-0.9f, 0.9f)),
                Coin.transform.rotation));
        }
    }
}