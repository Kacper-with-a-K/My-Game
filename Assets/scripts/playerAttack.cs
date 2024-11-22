using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public Player player;
    public Animator Attack;
    public GameObject heatAttack;
    // Start is called before the first frame update
    void Start()
    {
        Attack = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Attack.SetTrigger("Attack");
        }

        else if (Input.GetMouseButtonDown(1))
        {
            Attack.SetTrigger("HeavyAttack");
        }

        else if (Input.GetMouseButtonDown(1) && player.curHeat >= 75)
        {
            heatAttack.SetActive(true);
        }
    }

   

   

}
