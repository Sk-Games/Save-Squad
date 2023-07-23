using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    levelmanager lm;
    gameManager gm;
    public GameObject bomb;
    public bool enemyDamage = false;
    
    public GameObject fire;

    private void Awake()
    {
       gm = GameObject.Find("Spawner").GetComponent<gameManager>();
       lm = GameObject.Find("levelcontroller").GetComponent<levelmanager>();
        
    }

    private void Start()
    {
        StartCoroutine(monsterfire());
    }


    private void Update()
    {
        
    }


    IEnumerator monsterfire()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (gm.isAlive!=false && gm.gameWon==false)  // if game is not won and the player is alive then the enemy will attack
            {
                if (enemyDamage != true) // if enemy is not damaged and present in the scene then only enemy can attack
                {

                    GameObject clonefire = Instantiate(fire, transform.position, Quaternion.identity); //enemy attack
                    Destroy(clonefire, 1f); //destoyed the attack
                }
            }
            
        }
        

    }

    //new Vector3(gm.xpass, gm.ypass, 0f)
    private void OnMouseDown()  //special method when to detect the click
    {
        
        if (gm.isAlive!=false)    //if the player is alive then only player can damage the enemy
        {
            enemyDamage = true;  //enemy is damaged if it is alive and the mouse is clicked on enemy

            Destroy(this.gameObject);  //enemy is destroyed

            gm.score += lm.scorevalue;  // when enemy is destryed then the score is incremented according to the level
            GameObject clone = Instantiate(bomb, transform.position, Quaternion.identity); //the destroy affect is called
            Destroy(clone, 0.5f);
            gm.enemyCount++; //the no. of enemy died

        }
        
    }
}
