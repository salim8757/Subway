﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;



    public Text GameOver, scoreText, CoinText;

    public float Coin { get; set; }

    public float Score = 0;
    public float FinalScore = 0;
    float MaxScore = 0;


    public bool isFalling;

    float jumpspeed;
    float gravity = -10;

    Rigidbody playerRigidbody;



    public AudioClip CollectCoinAudio;
    public AudioClip HitAudio;


    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {

        GameOver.enabled = false;
        playerRigidbody = GetComponent<Rigidbody>();
        
  

    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position = new Vector3(transform.position.x
                + 5 * Time.deltaTime, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.LeftArrow))

            transform.position = new Vector3(transform.position.x

                - 5 * Time.deltaTime, transform.position.y, transform.position.z);


        if (transform.position.y > 0)
        { jumpspeed += gravity * Time.deltaTime; }
        else if (transform.position.y < 0)
        { transform.position = new Vector3(transform.position.x, 0, transform.position.z); }


        if (Input.GetKey(KeyCode.Space))
        {
            jumpspeed = 10;
        }

        transform.position += Vector3.up * jumpspeed * Time.deltaTime;



        caculateScore();


    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
        if (collision.gameObject.tag == "Stone")
        {
           
            DataManager.Instance.PlayerScore.Add(Score);
            DataManager.Instance.Score = Score; 


            GameOver.enabled = true;
            Destroy(gameObject);
            
            AudioScript.Instance.PlaySound("Hit");


           for(int i=0;i<=50;i++)
            {
                SceneManager.LoadScene("MainMenuScene");
            }
        }

    }

  



    private void OnTriggerEnter(Collider other)

    {
        print("onTrigger");
        if (other.tag == "coin")

        {
            Destroy(other.gameObject);
            Coin++;
            CoinText.text = "Coin : " + Coin;

            AudioScript.Instance.PlaySound("Collect");
        }

    }



    void caculateScore()
    {
        //Score = Time.deltaTime * 100;

        Score += 1;
        scoreText.text = "Score: " + Score;
        //DataManager.Instance.tempScore = Score;

    }

   
}
