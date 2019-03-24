using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControllerScript : MonoBehaviour
{

    public Button playButton;
    public Text Score, HighestScore, Title;
    public float currScore;
     float maxScore;
     float tempMaxScore;
      int Length;
     List<float> PlayerScore = new List<float>();



    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(SwitchScene);
        //currScore = DataManager.Instance.Score;
        Score.text = "Your Score: " + DataManager.Instance.Score.ToString();
        HighestScore.text = "Your Highest Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString();


    }

    // Update is called once per frame
    void Update()
    {
    
        //Title.text = "Game Over";


        maxScore = DataManager.Instance.Score;

        if (maxScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", maxScore);
            HighestScore.text = "Your Highest Score: " + maxScore.ToString();
        }

    }

    void SwitchScene()
    {
        //Counter.Instance.countGame++;

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


}
