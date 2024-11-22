using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{


    public int hitpoints;

    public int damage;

    public bool isDead;


    public bool isBlocking = false;

    public Animator hurt;



    // Start is called before the first frame update
    void Start()
    {
        hurt = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit!!!");
        if (collider.gameObject.tag == "Attack")
        {
            if (isBlocking == false)
            {
                hurt.SetTrigger("hurt");
                hitpoints -= damage;
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
            }

            if (isBlocking == true)
            {
                hitpoints -= ((damage * 2) - 1);
            }
        }

        else if (collider.gameObject.tag == "HeatAction")
        {
            hurt.SetTrigger("Heat");
            StartCoroutine(HeatActionDamage(8f));
        }
        damaged();
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

    public IEnumerator HeatActionDamage(float time)
    {
        yield return new WaitForSeconds(time);
        hitpoints -= (damage * 10);
    }
}
