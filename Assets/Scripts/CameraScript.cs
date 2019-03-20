using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;
    public Transform player;
    public Vector3 offest;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = player.position + player.TransformDirection(offest);
        Vector3 targetVector = target - transform.position;
        transform.LookAt(player.position + player.forward);
        transform.position += targetVector.normalized * speed * Time.deltaTime * Mathf.Min(3, targetVector.magnitude);
    }
}