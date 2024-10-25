using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vendingMachine : MonoBehaviour
{
    public GameObject InteractUI;
    public GameObject VendShopUI;
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
                InteractUI.SetActive(false);
                VendShopUI.SetActive(true);
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
        InteractUI.SetActive(false);
        VendShopUI?.SetActive(false);
        interui = false;
    }
}
