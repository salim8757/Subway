using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadWriteScript : MonoBehaviour
{


   public string key = "PlayerScore";
    float maxScore = 80;

    // Start is called before the first frame update
    void Start()
    {
        SaveMaxScore();

        getMaxScore();

    }

    void SaveMaxScore()
    {
        PlayerPrefs.SetFloat(key, maxScore);
    }

    void getMaxScore()
    {
        Debug.Log(PlayerPrefs.GetFloat(key));
        //Debug.Log(PlayerPrefs.GetFloat(key).ToString());
    }

    void resetScore()
    {
        //PlayerPrefs.DeleteKey(key);
        
    }

 


    // Update is called once per frame

}
