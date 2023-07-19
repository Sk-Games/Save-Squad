using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    Players pp;
    // Start is called before the first frame update
    void Start()
    {
        pp = GameObject.Find("player").GetComponent<Players>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        float dist = direction.magnitude;
        direction = direction.normalized;
        
        float move = speed * Time.deltaTime;
        //if (move > dist)
        //{
         //   move = dist;
        //}
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
