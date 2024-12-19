using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject InteractUI;
    public GameObject ShopUI;
    public bool interui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if (interui == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                InteractUI.SetActive(false);
                ShopUI.SetActive(true);
                interui = false;
            }
        }
    }
    


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PlayerArmature")
        {
            InteractUI.SetActive(true);
            interui = true;
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        InteractUI.SetActive(false);
        ShopUI?.SetActive(false);
        interui = false;
    }
}
