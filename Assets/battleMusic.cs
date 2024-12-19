using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleMusic : MonoBehaviour
{
    public AudioClip battleTheme;
    public float distance;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        bool enemyAgro = false;

        foreach (GameObject enemy in enemies)
        {
            if(Vector3.Distance(transform.position, enemy.transform.position) <= distance)
            {
                //Debug.Log("Enemy in range");
                enemyAgro = true;
                break;
            }
        }

        if(enemyAgro)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else if(!enemyAgro)
        {
            if(audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
