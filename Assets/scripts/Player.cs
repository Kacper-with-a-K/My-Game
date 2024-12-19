using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public CharacterController cc;
    public GameObject Inventory;
    public bool InventoryOpen;
    public int maxHealth;
    public int curHealth;
    public healthbar healthbar;
    public heatbar heatbar;
    public int maxHeat;
    public int curHeat;
    public Boolean Heat;
    public GameObject heatAura;
    public AudioSource hurt;
    public Animator animator;

    public int damage;

    
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        
    }


    // Update is called once per frame
    

    void Update()
    {
        if(curHeat >= 75)
        {
            animator.SetBool("Heat", true);
            Heat = true;
            heatAura.SetActive(true);
        }
        else if(curHeat < 75)
        {
            animator.SetBool("Heat", false);
            Heat = false;
            heatAura.SetActive(false);
        }

        if(curHeat > 100)
        {
            curHeat = 100;
        }
        else if(curHeat < 0)
        {
            curHeat = 0;
        }

        if(curHealth <= 0)
        {
            animator.SetBool("Dead", true);
            cc.enabled = false;
        }
        if(curHealth > 100)
        {
            curHealth = 100;
        }
        seeInventory();
        healthbar.UpdateHealth((float)curHealth / (float)maxHealth);
        heatbar.UpdateHeat((float)curHeat  / (float)maxHeat);
    }

    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemyAttack")
        {
            hurt.Play();
            curHealth -= damage;
            curHeat -= 2;
        }
    }

    public void Loss()
    {
        SceneManager.LoadScene("Loss");
    }
    public void HeatAction()
    {
        curHeat -= 75;
    }
    public void seeInventory()
    {
        if(InventoryOpen == false)
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                Inventory.SetActive(true);
                InventoryOpen = true;
            }
        }
        else if (InventoryOpen == true)
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                Inventory.SetActive(false);
                InventoryOpen = false;
            }
        }
    }
}
