using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void purchaseHeat()
    {
        GameObject playerScript = GameObject.Find("PlayerArmature");
        Player player = playerScript.GetComponent<Player>();
        GameObject moneyScript = GameObject.Find("cash");
        money cash = moneyScript.GetComponent<money>();
        if (cash.cash >= 50)
        {
        player.curHeat += 60;
        cash.cash -= 50;
        }
        else
        {
            Debug.Log("Not enough cash!!!");
        }
    }

    public void purchaseHealth()
    {
        
        GameObject playerScript = GameObject.Find("PlayerArmature");
        Player player = playerScript.GetComponent<Player>();
        GameObject moneyScript = GameObject.Find("cash");
        money cash = moneyScript.GetComponent<money>();
        if (cash.cash >= 30)
        {
        player.curHealth += 40;
        cash.cash -= 30;
        }
        else
        {
            Debug.Log("Not enough cash!!!");
        }
    }

    public void purchaseVendHeat()
    {
        GameObject playerScript = GameObject.Find("PlayerArmature");
        Player player = playerScript.GetComponent<Player>();
        GameObject moneyScript = GameObject.Find("cash");
        money cash = moneyScript.GetComponent<money>();
        if (cash.cash >= 10)
        {
        player.curHeat += 10;
        cash.cash -= 10;
        }
        else
        {
            Debug.Log("Not enough cash!!!");
        }
    }

    public void purchaseVendHealth()
    {
        
        GameObject playerScript = GameObject.Find("PlayerArmature");
        Player player = playerScript.GetComponent<Player>();
        GameObject moneyScript = GameObject.Find("cash");
        money cash = moneyScript.GetComponent<money>();
        if (cash.cash >= 10)
        {
        player.curHealth += 10;
        cash.cash -= 10;
        }
        else
        {
            Debug.Log("Not enough cash!!!");
        }
    }
}
