using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour
{
    enum level1
    {
        noOfEnemy = 50,
        damage = 3,
    }

    level1 damage = level1.damage;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((int)damage);
    }
}
