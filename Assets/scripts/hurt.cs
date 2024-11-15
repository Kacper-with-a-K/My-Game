using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurt : MonoBehaviour
{
    public int damage;
    public int combotime;

    public bool onHit = false;

    public bool onBlock = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        if(onHit == true)
        {
            Debug.Log("Hit!!!");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            onHit = true;
            var hit = GetComponent<enemy>();
            hit.damaged();
            onHit = false;
        }
    }
}
