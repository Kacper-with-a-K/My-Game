using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyChase : MonoBehaviour
{
    public GameObject target;
    public bool spotted;
    
    public float speed = 1;
    public float rotationSpeed = 5f;

    public float stopDistance = 0.7f;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        //Debug.Log(dist);
        if (dist > stopDistance && dist < 5f)
        {
            spotted = true;
            animator.SetBool("attack", false);
            animator.SetBool("far", true);
            animator.SetBool("close", false);
            Vector3 rangeToClose = target.transform.position - transform.position;
            rangeToClose.y = 0;

            float distance = rangeToClose.magnitude;
            float speedDelta = speed * Time.deltaTime;
            Vector3 normalizedRangeToClose = rangeToClose.normalized;

            if (normalizedRangeToClose != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(normalizedRangeToClose);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            Vector3 delta = speedDelta * normalizedRangeToClose;
            transform.Translate(delta, Space.World);

        }
        else if (spotted == true && dist <= stopDistance)
        {
            animator.SetBool("far", false);
            animator.SetBool("close", true);
            animator.SetBool("attack", true);
        }

        else if (spotted == true && dist > 5f)
        {
            spotted = false;
            animator.SetBool("far", false);
            animator.SetBool("close", false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            spotted = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == target)
        {
            animator.SetBool("far", false);
            animator.SetBool("close", false);
            spotted = false;
        }
    }
}
