using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    gameManager gm;
    public GameObject bomb;
    public bool enemyDamage = false;
    float rangeX;
    float rangeY;
    public GameObject fire;

    private void Awake()
    {
       gm = GameObject.Find("Spawner").GetComponent<gameManager>();
        
    }

    private void Start()
    {
        StartCoroutine(monsterfire());
    }


    void Update()
    {
        
       Destroy(this.gameObject, 3f);
    }
    //new Vector3(rangeX, rangeY, 0f)
    IEnumerator monsterfire()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (enemyDamage != true)
            {
                
                GameObject clonefire = Instantiate(fire, transform.position, Quaternion.identity);
                Destroy(clonefire, 1f);
            }
        }
        

    }

    //new Vector3(gm.xpass, gm.ypass, 0f)
    private void OnMouseDown()
    {
        
        enemyDamage = true;
        
        Destroy(this.gameObject);

        gm.score++;
        GameObject clone = Instantiate(bomb, transform.position,Quaternion.identity);
        Destroy(clone, 0.5f);
    }
}
