using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public static Player Instance;

    public Text GameOver, scoreText, CoinText;
    public float Coin { get; set; }
    public float Score { get; set; }

    private float gravity = -2;

    private float Speed = 5;

    public bool isFalling;

    Rigidbody playerRigidbody;

   // public AudioSource HitAudio;
    Vector3 originalposition;

    public AudioClip CollectCoinAudio;
    public AudioClip HitAudio;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerController.Instance.MyPlayer = this;
        //GameOver.enabled = false;
        playerRigidbody = GetComponent<Rigidbody>();

       // HitAudio = GetComponent<AudioSource>();
        originalposition = transform.position;


 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))

            transform.position = new Vector3(transform.position.x

                + 5 * Time.deltaTime, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.LeftArrow))

            transform.position = new Vector3(transform.position.x

                - 5 * Time.deltaTime, transform.position.y, transform.position.z);



        if (Input.GetKeyDown(KeyCode.Space))
        {

          transform.position = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
          print("up");
            


        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

          transform.position = originalposition;
           print("down");

        }

        caculateScore();


    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
        if (collision.gameObject.tag == "Stone")
        {
            GameOver.enabled = true;
            Destroy(gameObject);
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.PlayOneShot(HitAudio);
            //DataManager.Instance.MaxScore = 10;
            // scoreText
            //print(DataManager.Instance.MaxScore);
            //AudioScript.Instance.HitAudio(true);

            SceneManager.LoadScene("MainMenuScene");
            print("GAMEOVER");
            AudioScript.Instance.PlaySound("Hit");
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
            //AudioSource audio = GetComponent<AudioSource>();

            //audio.PlayOneShot(CollectCoinAudio);

            //AudioSource audio = GetComponent<AudioSource>();
            //audio.PlayOneShot(CollectCoinAudio);
            //AudioScript.Instance.CollectCoinsAudio();
            AudioScript.Instance.PlaySound("Collect");
        }



    }



    void comeBack()

    {

        isFalling = false;
        transform.Translate(0, 0, 0);

    }

    void caculateScore()
    {
        Score = Time.deltaTime * 100;
        scoreText.text = "Score: " + Score;
    }
}
