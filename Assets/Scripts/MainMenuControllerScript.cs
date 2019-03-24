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
    float maxScore;
   
    



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
    
       


        maxScore = DataManager.Instance.Score;

        if (maxScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", maxScore);
            HighestScore.text = "Your Highest Score: " + maxScore.ToString();
        }

    }

    void SwitchScene()
    {
      

        SceneManager.LoadScene("GameScene");
    }

    public void SoundOn()
    {
     
        AudioScript.Instance.ToggleMuteSound();
    }

    public void MusicOn()
    {
        AudioScript.Instance.Music();
    }


}
