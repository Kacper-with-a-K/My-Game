using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveSpeed = 10f;

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
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward.Normalize();
        camRight.Normalize();

        Vector3 forwardRelative = verInput * camForward;
        Vector3 rightRelative = horInput * camRight;
        Vector3 moveDir = forwardRelative + rightRelative;

        

        rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
        transform.forward = moveDir;
        
    }

    
}
