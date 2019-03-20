using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControllerScript : MonoBehaviour
{

    public Button playButton;
    public Text Score, HighestScore;
    public int GameCount = 0; 


    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(SwitchScene);
        HighestScore.enabled = false;
        Score.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the text's score
        //  Set the text's highest score

        if (GameCount != 0)
        {
            HighestScore.enabled = true;
            Score.enabled = true;
        }
    }

    void SwitchScene()
    {
        GameCount++;
        SceneManager.LoadScene("GameScene");
    }

    public void SoundOn(bool newValue)
    {
        if (newValue)
        {
            // Turn Sound on
            print("Sounds on");
        }

    }

    public void MusicOn(bool newValue)
    {
        if (newValue)
        {
            // Turn Music on
            print("Music on");
        }

    }

    

}
