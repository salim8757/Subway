using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


   

    // Start is called before the first frame update
    void Start()
    {
    
        DataManager.Instance.MaxScore = 10;
        print(DataManager.Instance.MaxScore);
        DataManager.Instance.PlayerName = "Ahlam";
        print(DataManager.Instance.PlayerName);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Max score:" + PlayerPrefs.GetFloat(Key));
    }
}
