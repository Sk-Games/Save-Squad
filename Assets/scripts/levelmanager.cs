using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{

    public int scorevalue = 1;
    public int healthDamage = 1;
    public float spawnSpeed = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            scorevalue = 5;
            healthDamage = 1;
            spawnSpeed = 5;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            scorevalue = 4;
            healthDamage = 2;
            spawnSpeed = 4;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            scorevalue = 3;
            healthDamage = 3;
            spawnSpeed = 3;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            scorevalue = 2;
            healthDamage = 4;
            spawnSpeed = 2;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            scorevalue = 1;
            healthDamage = 5;
            spawnSpeed = 1f;
        }

    }
}
