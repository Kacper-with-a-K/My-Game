using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basement : MonoBehaviour
{

    public GameObject InteractUI;

    public GameObject Player;
    public bool interui;
    public GameObject entry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interui == true)
        {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Teleported");
            CharacterController characterController = Player.GetComponent<CharacterController>();
        if (characterController != null)
        {
            characterController.enabled = false; // Disable before changing position
        }
            Player.transform.position = entry.transform.position;
            Player.transform.rotation = entry.transform.rotation;
            InteractUI.SetActive(false);
            interui = false;
        
        if (characterController != null)
        {
            characterController.enabled = true;
        }
        Destroy(gameObject);

        }

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InteractUI.SetActive(true);
            interui = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        InteractUI.SetActive(false);
        interui = false;
    }
}
