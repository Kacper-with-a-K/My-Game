using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heatbar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Image Heatbar;

    public void UpdateHeat(float fraction)
    {
        Heatbar.fillAmount = fraction;
    }
}
