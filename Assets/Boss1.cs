using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void teleportPlayer()
    {
         CharacterController characterController = Player.GetComponent<CharacterController>();
        if (characterController != null)
        {
            characterController.enabled = false; // Disable before changing position
        }
            Player.transform.position = exit.transform.position;
            Player.transform.rotation = exit.transform.rotation;
        
        if (characterController != null)
        {
            characterController.enabled = true;
        }
    }
}
