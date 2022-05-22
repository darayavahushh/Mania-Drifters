using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    public static AudioManager audioInstance;


    void Awake()
    {
        if (audioInstance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            audioInstance = this;
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
}
