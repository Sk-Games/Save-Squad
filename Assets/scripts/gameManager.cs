using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject[] enemy;

    public bool isAlive = true;

    float rangeX;
    float rangeY;

    public float xpass;
    public float ypass;


    public GameObject panel;

    [Header("health")]

    public int health;
    public TMP_Text healthText;

    [Header("Score")]

    public TMP_Text scoreText;
    public int score;


    public TMP_Text scoreText1;
    public TMP_Text highScoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        scoreText.text = "Score : " + score;

        if (health > 30)
        {
            healthText.color = Color.green;
        }else if (health <= 30 && health >=20)
        {
            healthText.color = Color.yellow;
        }
        else
        {
            healthText.color = Color.red;
        }

        if (health <= 0)
        {

            int highScore = PlayerPrefs.GetInt("HighScore", 0);
            CancelInvoke("spawn");
            isAlive = false;
            panel.SetActive(true);
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
            }
            scoreText1.text = "Your Score : " + score;
            highScoreText.text = "High Score : "+highScore;
        }
    }

    void spawn()
    {
        rangeX = Random.Range(-6.36f, 5.62f);
        rangeY = Random.Range(-1.66f, 3.4f);
        xpass = rangeX;
        ypass = rangeY;
        int prefabIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[prefabIndex], new Vector3(rangeX, rangeY, 0f), Quaternion.identity);
    }
    


    
}
