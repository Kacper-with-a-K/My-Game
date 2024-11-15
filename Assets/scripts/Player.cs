using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Inventory;
    public bool InventoryOpen;
    public int maxHealth;
    public int curHealth;
    public healthbar healthbar;
    public int maxHeat;
    public int curHeat;


    
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        curHeat = maxHeat;
    }


    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        curHealth -= damage;
        healthbar.UpdateHealth((float)curHealth / (float)maxHealth);
    }

    void Update()
    {
        seeInventory();
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
