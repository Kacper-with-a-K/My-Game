using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cash : MonoBehaviour
{
    

    //public GameObject money;
    //public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Money Touched!");
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject dollar = GameObject.Find("cash");
            money moneyScript = dollar.GetComponent<money>();
            Debug.Log("Money Collected!");
            
            moneyScript.cash += 10;
            Destroy(gameObject);
        }
    }

    public  void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        Debug.Log("Money Collected!");
        GameObject dollar = GameObject.Find("cash");
        money moneyScript = dollar.GetComponent<money>();
        Debug.Log("Money Collected!");
        moneyScript.cash += 10;
        Destroy(gameObject);
    }
}
}
