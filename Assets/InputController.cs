using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private float jump = 5;
    private float Speed = 5;
    public bool isFalling;
    Rigidbody playerRigidbody;
    public AudioSource HitAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        HitAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Play"))
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position = new Vector3(transform.position.x
                + 5 * Time.deltaTime, transform.position.y, transform.position.z);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position = new Vector3(transform.position.x
                - 5 * Time.deltaTime, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.Space) && isFalling == false)
        {
            playerRigidbody.velocity = new Vector3(0f, jump, 0f);
            isFalling = true;
        }
    }


    //to make sure you can't jump while in mid-air I use the following:
    void OnCollisionStay()
    {
        isFalling = false;
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Stone")
        {
            HitAudio.Play();
            Destroy(this);

        }
    }
}
