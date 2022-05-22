using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
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
        Debug.Log(original.sprite);
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
