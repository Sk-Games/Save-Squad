using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public static MenuController instance;

    int nextLevel = 1;
    int currentlevel = 0;


    private void Start()
    {
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        /*  if (instance)
          {
              Destroy(this.gameObject);
          }
          else
          {
              instance = this;
          }*/
        if ( currentlevel != 0)
        {
            nextLevel = SceneManager.GetActiveScene().buildIndex;
        }
    }


    public void StartGame()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void QuitGame()
    {
        Application.Quit();

    }

    public void Restart()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextLevel);
        
    }

    public void nextScene()
    {
        nextLevel += 1;
        SceneManager.LoadScene(nextLevel);
    }
    public void PreviousLevel()
    {
        if (nextLevel>1)
        {
            nextLevel -= 1;
            SceneManager.LoadScene(nextLevel);
        }
        
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
       // DontDestroyOnLoad(this);
    }
}
