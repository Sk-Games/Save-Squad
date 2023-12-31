using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    levelmanager lm;

    public GameObject player;
    public float speed = 10f;
    gameManager pp;
    

    void Start()
    {
        pp = GameObject.Find("Spawner").GetComponent<gameManager>();
        lm = GameObject.Find("levelcontroller").GetComponent<levelmanager>();
    }

    
    void Update()
    {
        
        if (pp.isAlive != false)
        {
            Vector3 direction = player.transform.position - this.transform.position;
            float dist = direction.magnitude;
            direction = direction.normalized;

            float move = speed * Time.deltaTime;

            transform.Translate(move * direction);

            if (transform.position.y <= -4.62f)
            {
                pp.health -= lm.healthDamage;
                //player.gameObject.GetComponent<Players>().phealth--;  // this was refering to the player prefab the changes made in prefab remain after the execution end.
                //Debug.Log(pp.health);

                Destroy(gameObject);
            }

        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
