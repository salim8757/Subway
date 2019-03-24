using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public static AudioScript Instance;

    AudioSource myAudio;

    public AudioClip eatCoin;
    public AudioClip HitStone;
    public AudioClip MusicBackground;

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
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

  

    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "Hit":
                myAudio.clip = HitStone;
                break;
            case "Collect":
                myAudio.clip = eatCoin;
                break;
        }

        myAudio.Play();
    }

   

    public void Music()
    {
        if (!myAudio.isPlaying)
        {
            myAudio.clip = MusicBackground;
            //if (MusicOn)
            myAudio.Play();
            print("music Audio");
        }
        else
            myAudio.Stop();
    }

    public void ToggleMuteSound()
    {
        if (myAudio.volume == 1)
            myAudio.volume = 0;
        else if (myAudio.volume == 0)
            myAudio.volume = 1;
    }
}
