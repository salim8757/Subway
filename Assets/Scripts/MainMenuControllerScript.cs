using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControllerScript : MonoBehaviour
{

    public Button playButton;
    public Text Score, HighestScore, Title;
   // public int GameCount = 0;
    public float maxScore = 0.0f;



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

      

            Title.text = "Game Over";
            float currentScore = Player.Instance.Score;
            //float MAX_Score = Player.Instance.MaxScore;
            HighestScore.enabled = true;
            Score.enabled = true;

            Score.text = currentScore.ToString();
            checkMax();



        

        //DataManager.Instance.MaxScore = 0;

        //HighestScore.text = Player.Instance.Score.ToString();
        //print(DataManager.Instance.MaxScore);
        //HighestScore.enabled = true;

    }

    void SwitchScene()
    {
       // GameCount++;
        SceneManager.LoadScene("GameScene");
    }

    public void SoundOn()
    {
        // Turn Sound on
        //print("Sounds on");
        //// AudioScript.Instance.SoundOn = true;
        //AudioScript.Instance.CollectCoinsAudio(true);
        //AudioScript.Instance.HitAudio();
        AudioScript.Instance.ToggleMuteSound();
    }

    public void MusicOn()
    {
        AudioScript.Instance.Music();
    }

    public void checkMax()
    {
        if (Player.Instance.Score > maxScore)
        {
            maxScore = Player.Instance.Score;
            
        }
        HighestScore.text = maxScore.ToString();

    }
}
