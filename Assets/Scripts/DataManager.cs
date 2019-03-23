﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataManager : MonoBehaviour
{
    public static DataManager Instance;


    public List<float> PlayerScore = new List<float>();
    public float Score; 


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

    }

    
   

}