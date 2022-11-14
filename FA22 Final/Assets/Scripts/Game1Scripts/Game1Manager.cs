using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Manager : MonoBehaviour
{
    public FunnelTrigger funnelTrigger;
    public EdgeTrigger edgeTrigger;
    public Animator failAnim;
    public Animator successAnim;

    private void Start()
    {
        funnelTrigger = GameObject.Find("FunnelTrigger").GetComponent<FunnelTrigger>();
        edgeTrigger = GameObject.Find("EdgeTrigger").GetComponent<EdgeTrigger>();
        failAnim = GetComponent<Animator>();
        successAnim = GetComponent<Animator>();
    }

    public void Game1Results()
    {
        if (funnelTrigger.Game1Fail == false || edgeTrigger.Game1Fail == false)
        {
            Debug.Log("You Passed Game 1!");
            successAnim.Play("checkAnim");
        }
        if (funnelTrigger.Game1Fail == true || edgeTrigger.Game1Fail == true)
        {
            Debug.Log("You Failed Game 1!");
            failAnim.Play("xAnim");
        }
    }
    
}
