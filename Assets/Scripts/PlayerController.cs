using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text GameOver, scoreText, CoinText;



    // Start is called before the first frame update
    void Start()
    {
        GameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            GameOver.enabled = true;
            Destroy(gameObject);
            // Record the score 

        }

    }

}
