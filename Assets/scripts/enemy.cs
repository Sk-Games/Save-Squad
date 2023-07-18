using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    gameManager gm;
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

        Destroy(this.gameObject);
        gm.score++;
    }
}
