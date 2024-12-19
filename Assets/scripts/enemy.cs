using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public enemyHealth healthbar;
    public int hitpoints;
   
    public int damage;

    public bool isDead;

    public Player player;

    public GameObject money;
    public bool isBlocking = false;

    public Animator hurt;

    public AudioSource smallHit;
    public AudioSource bigHit;
    public AudioSource megaHit;

    // Start is called before the first frame update
    void Start()
    {
        hurt = GetComponent<Animator>();
  
    }

    // Update is called once per frame
    void Update()
    {
        if(hitpoints <= 0)
        {
            isDead = true;
            hurt.SetBool("dead", true);
        }
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Attack")
        {
            if (isBlocking == false)
            {
                Debug.Log("Hit!!!");
                hurt.SetTrigger("hurt");
                hitpoints -= damage;
                player.curHeat += 3;
                smallHit.Play();
            }

            if (isBlocking == true)
            {
                hitpoints -= (damage - 1);
            }

        }

        else if (collider.gameObject.tag == "HeavyAttack")
        {
            if (isBlocking == false)
            {
                hurt.SetTrigger("BigHurt");
                hitpoints -= (damage * 2);
                player.curHeat += 5;
                bigHit.Play();
            }

            if (isBlocking == true)
            {
                hitpoints -= ((damage * 2) - 1);
            }
        }

        else if (collider.gameObject.tag == "HeatAction")
        {
            hurt.SetTrigger("Heat");
            hitpoints -= (damage * 3);
            megaHit.Play();
        }
        //damaged();
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
    public void dropMoney()
    {
        Instantiate(money, transform.position, transform.rotation);
    }
    public void damaged()
    {
        
        Debug.Log("Damaged");

        if (isBlocking == false)
        {
            hitpoints -= damage;
        }

        if (isBlocking == true)
        {
            hitpoints -= (damage - 1); 
        }
    }

    
}
