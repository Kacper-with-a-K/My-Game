using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toxic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void OnTriggerEnter(Collider collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Player fell in");
        Player player = collision.GetComponent<Player>();
        player.curHealth -= 10;
    }
}
}
