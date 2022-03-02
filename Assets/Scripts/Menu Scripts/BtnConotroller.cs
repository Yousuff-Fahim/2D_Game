using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnConotroller : MonoBehaviour
{
    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level Select");
    }

    public void Controls()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controls");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Level1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 3");
    }
}
