using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScene : MonoBehaviour
{
    // The FadeOut function doesn not work so far

    public Animator animator;
    private Scene scene;

    void Awake()
    {
        this.scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (!string.Equals(SceneManager.GetActiveScene().path, this.scene.path)))
        {
            this.scene = SceneManager.GetActiveScene();
            FadeToLevel();
        }
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }
}
