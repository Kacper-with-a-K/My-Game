using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hitpoints;

    public bool isDead;

    public bool isBlocking;

    public hurt takeDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damaged()
    {
        var hurt = GetComponent<hurt>();
        

        if (isBlocking == false)
        {
            hitpoints -= hurt.damage;
        }

        if (isBlocking == true)
        {
            hitpoints -= (hurt.damage - 1); 
        }
    }
}
