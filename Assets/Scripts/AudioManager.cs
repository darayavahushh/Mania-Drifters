using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;
    private bool isOriginal = true;

    // Start is called before the first frame update
    void Start()
    {
        oldSprite = original.sprite;
    }

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "GameScene")
        {
            // Stops playing music in GameScene scene
            Destroy(gameObject);
        }
    }

    public void MuteToggle()
    {
        if (isOriginal == true)
        {
            original.sprite = newSprite;
            isOriginal = false;
            AudioListener.volume = 0;
        }
        else
        {
            original.sprite = oldSprite;
            isOriginal = true;
            AudioListener.volume = 1;
        }
    }
}
