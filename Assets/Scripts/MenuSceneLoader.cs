using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneLoader : MonoBehaviour
{
    // Change scenes
    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void GoToCarSelect()
    {
        SceneManager.LoadScene("CarMenuScene");
    }

    public void GoToMapSelect()
    {
        SceneManager.LoadScene("MapMenuScene");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("RCC City");
    }

}
