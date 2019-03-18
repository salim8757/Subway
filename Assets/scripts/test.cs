using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public string key = "PlayerScore";
    //ReadWriteScript script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Max score:" + PlayerPrefs.GetFloat(key));
    }
}
