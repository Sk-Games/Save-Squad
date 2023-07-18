using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    gameManager gm;
    public GameObject bomb;

    float rangeX;
    float rangeY;

    private void Awake()
    {
       gm = GameObject.Find("Spawner").GetComponent<gameManager>();
    }
    
    
    
    
    void Update()
    {
        
        Destroy(this.gameObject, 2f);
    }


    private void OnMouseDown()
    {
        /*
        rangeX = Random.Range(-6.36f, 5.62f);
        rangeY = Random.Range(-1.66f, 3.4f); */
        Destroy(this.gameObject);
        gm.score++;
        GameObject clone = Instantiate(bomb, new Vector3(gm.xpass, gm.ypass, 0f),Quaternion.identity);
        Destroy(clone, 0.5f);
    }
}
