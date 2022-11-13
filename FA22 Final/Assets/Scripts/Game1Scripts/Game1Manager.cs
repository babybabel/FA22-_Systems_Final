using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Manager : MonoBehaviour
{
    public FunnelTrigger funnelTrigger;
    public EdgeTrigger edgeTrigger;

    private void Start()
    {
        funnelTrigger = GameObject.Find("FunnelTrigger").GetComponent<FunnelTrigger>();
        edgeTrigger = GameObject.Find("EdgeTrigger").GetComponent<EdgeTrigger>();
    }

    public void Game1Results()
    {
        if (funnelTrigger.Game1Fail == false || edgeTrigger.Game1Fail == false)
        {
            Debug.Log("You Passed Game 1!");
        }
        else
        {
            Debug.Log("You Failed Game 1!");
        }
    }
    
}
