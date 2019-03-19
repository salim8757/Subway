using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    public static DataManager Instance;

    public float MaxScore
    {
        get
        {
            return PlayerPrefs.GetFloat("PlayerScore", 0);
        }
        set
        {
            PlayerPrefs.SetFloat("PlayerScore", value);
          
        }
    }

    public string PlayerName
    {
        get
        {
            return PlayerPrefs.GetString("Name", "");
        }
        set
        {
            PlayerPrefs.SetString("Name", value);

        }
    }


    // Start is called before the first frame update

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        //SaveMaxScore();

        //getMaxScore();

    }

    //public void SaveMaxScore(float score)
    //{
    //    PlayerPrefs.SetFloat("PlayerScore", score);
    //    MaxScore = score;
    //}

    //public float getMaxScore()
    //{
    //    //Debug.Log(PlayerPrefs.GetFloat(Key));
    //    ////Debug.Log(PlayerPrefs.GetFloat(key).ToString());
    //    return PlayerPrefs.GetFloat("PlayerScore", 0);
    //}

    //void resetScore()
    //{
    //    //PlayerPrefs.DeleteKey(key);

    //}




    // Update is called once per frame

}
