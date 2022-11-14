using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Manager : MonoBehaviour
{

    public LightClicker lightClicker;
    public Animator failAnim;
    public Animator successAnim;
    
    void Start()
    {
        lightClicker = GameObject.Find("LightClicker").GetComponent<LightClicker>();
        failAnim = GetComponent<Animator>();
        successAnim = GetComponent<Animator>();
    }

    public void Game2Results()
    {
        if (lightClicker.Game2Fail == false)
        {
            Debug.Log("You Passed Game 2!");
            successAnim.Play("checkAnim");

        }
        if (lightClicker.Game2Fail == true)
        {
            Debug.Log("You Failed Game 2!");
            failAnim.Play("xAnim");
        }
    }
    
}
