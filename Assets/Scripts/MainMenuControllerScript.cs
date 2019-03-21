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
    public float maxScore;
    



    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(SwitchScene);
        HighestScore.enabled = true;
        Score.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
     

            Title.text = "Game Over";
            float currentScore = Player.Instance.Score;
             print(currentScore);
            //float MAX_Score = Player.Instance.MaxScore;
            // HighestScore.enabled = true;
            // Score.enabled = true;

            Score.text = currentScore.ToString();
        //eckMax();
        float scoreCurrGame = Player.Instance.Score;
        float HScoreWholeGame = DataManager.Instance.MaxScore;
        if (scoreCurrGame > HScoreWholeGame)
        {
            //DataManager.Instance.MaxScore = Player.Instance.Score;
            HScoreWholeGame = scoreCurrGame;
        }
        DataManager.Instance.MaxScore = HScoreWholeGame;

        HighestScore.text = HScoreWholeGame.ToString();




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

        float scoreCurrGame = Player.Instance.Score;
        float HScoreWholeGame = 0;
         HScoreWholeGame = DataManager.Instance.MaxScore;
        if (scoreCurrGame > HScoreWholeGame)
        {
            //DataManager.Instance.MaxScore = Player.Instance.Score;
            HScoreWholeGame = scoreCurrGame;
        }
        DataManager.Instance.MaxScore = HScoreWholeGame;

        HighestScore.text = HScoreWholeGame.ToString();


    }
}
