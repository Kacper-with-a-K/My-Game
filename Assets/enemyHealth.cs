using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider health;

    void Start()
    {
        health = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int hitpoints, int maxhitpoints)
    {
        health.value = hitpoints/maxhitpoints;
    }
}
