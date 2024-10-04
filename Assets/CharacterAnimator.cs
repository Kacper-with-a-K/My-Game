using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("walk", false);
            }
            animator.SetBool("walk", true);
        }

        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("run", true);
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("run", false);
        }
    }
}
