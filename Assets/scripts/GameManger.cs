using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public static GameManger Instance;

    public float Score;

    public float MaxScore
    {
        get { return PlayerPrefs.GetFloat("PlayerMaxScore", 0); }

        set { PlayerPrefs.SetFloat("PlayerMaxScore", value); }
    }



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
    {}

    // Update is called once per frame
    void Update()
    {}


    
    //private void OnTriggerEnter(Collider other)
    //{
        
    //    if(other.gameObject.tag=="Coin")
    //    {



    //    }
    //}


}
