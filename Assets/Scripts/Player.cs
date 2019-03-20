using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    ////public Text GameOver, scoreText, CoinText;
    ////public float Score { get; set; }
    private float jump = 2;

    private float Speed = 5;

    public bool isFalling ;

    Rigidbody playerRigidbody;

    public AudioSource HitAudio;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerController.Instance.MyPlayer = this;
        //GameOver.enabled = false;
        playerRigidbody = GetComponent<Rigidbody>();

        HitAudio = GetComponent<AudioSource>();
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



        if (Input.GetKey(KeyCode.Space) && isFalling == false )

        {
            print("jump");
            //playerRigidbody.velocity = new Vector3(0f, jump, 0f);
            transform.Translate(0, jump,0);
           // transform.up(0, jump, 0);
            isFalling = true;
            comeBack();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            ////GameOver.enabled = true;
            ////Destroy(gameObject);
            ////// Record the score 
            ////SceneManager.LoadScene("MainMenuScene
            print("GAMEOVER");
        }

    }

    private void OnTriggerEnter(Collider other)
    {

    }


    void comeBack()

    {

        isFalling = false;
        transform.Translate(0, 0, 0);

    }
}
