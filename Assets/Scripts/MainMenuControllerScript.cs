using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControllerScript : MonoBehaviour
{

    public Button playButton, saveSettingButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(SwitchScene);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SwitchScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
