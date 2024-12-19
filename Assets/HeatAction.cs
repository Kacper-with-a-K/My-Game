using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatAction : MonoBehaviour
{
    public Player player;
    public enemy enemy;
    public Animator heatMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.curHeat >= 75)
        {
            heatMove.SetBool("Heat", true);
        }
        else if(player.curHeat <75)
        {
            heatMove.SetBool("Heat", false);
        }

      
    }

    public void OnTriggerEnter(Collider collider)
    {
        
    }


}
