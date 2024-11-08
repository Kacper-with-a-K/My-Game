using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [Header("Light combo")]
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            attack1.SetActive(true);
            StartCoroutine(StopAttack(0.5f));        }
    }

    IEnumerator StopAttack(float time)
    {
        yield return new WaitForSeconds(time);
        attack1.SetActive(false);
    }
}
