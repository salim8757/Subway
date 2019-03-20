using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject Coin;
    Transform myTransform;
    float spwanTimer = 1;

    List<GameObject> allCoins;

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
            spwanTimer = 1;

            Instantiate(Coin, new Vector3
            (Random.Range(-0.9f, 0.9f), 0.5f, myTransform.transform.position.z + 5), Coin.transform.rotation);
        }
    }
    public Text Scoring;
    int Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        Destroy(other.gameObject);
        Score++;
        Scoring.text = "Score: " + Score;
    }
}