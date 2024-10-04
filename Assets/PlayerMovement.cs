using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveSpeed = 10f;
    Vector3 camForward = cam.forward;
    Vector3 camRight = cam.right;

    [SerializeField] Transform cam;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float verInput = Input.GetAxisRaw("Vertical") * moveSpeed;
        

        

        camForward.Normalize();
        camRight.Normalize();

        Vector3 forwardRelative = verInput * camForward;
        Vector3 rightRelative = horInput * camRight;
        Vector3 moveDir = forwardRelative + rightRelative;

        

        rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
        transform.forward = moveDir;
        
    }

    void Inputs()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 15f;
        }
    }

    void OnMove()
    {

    }

    
}
