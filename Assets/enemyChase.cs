using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyChase : MonoBehaviour
{
    public GameObject target;
    public bool spotted;
    
    public float speed = 1;
    public float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spotted == true)
        {
            Vector3 rangeToClose = target.transform.position - transform.position;

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
            spotted = false;
        }
    }
}
