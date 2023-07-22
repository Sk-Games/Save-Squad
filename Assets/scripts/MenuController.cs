using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    int currentLevel = 1;
    public void StartGame()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void QuitGame()
    {
        Application.Quit();

    }

    public void Restart()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        DontDestroyOnLoad(this);
    }
}
