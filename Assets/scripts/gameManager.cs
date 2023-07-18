using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject[] enemy;
    

    float rangeX;
    float rangeY;

    public TMP_Text scoreText;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    void spawn()
    {
        rangeX = Random.Range(-6.36f, 5.62f);
        rangeY = Random.Range(-1.66f, 3.4f);
        int prefabIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[prefabIndex], new Vector3(rangeX, rangeY, 0f), Quaternion.identity);

    }
}