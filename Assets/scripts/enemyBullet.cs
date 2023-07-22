using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    gameManager pp;
    
    void Start()
    {
        pp = GameObject.Find("Spawner").GetComponent<gameManager>();
    }

    
    void Update()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        float dist = direction.magnitude;
        direction = direction.normalized;
        
        float move = speed * Time.deltaTime;
       
        transform.Translate(move * direction);
        if (transform.position.y<= -4.62f)
        {
            pp.health--;
            //player.gameObject.GetComponent<Players>().phealth--;  // this was refering to the player prefab the changes made in prefab remain after the execution end.
            Debug.Log(pp.health);
            Destroy(gameObject);
        }
    }
}
