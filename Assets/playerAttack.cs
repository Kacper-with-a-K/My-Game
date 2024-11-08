using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class playerAttack : MonoBehaviour
{

    public Animator Attack;
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
    }

   

   

}
