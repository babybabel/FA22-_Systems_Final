using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Manager : MonoBehaviour
{

    public LightClicker lightClicker;
    
    void Start()
    {
        lightClicker = GameObject.Find("LightClicker").GetComponent<LightClicker>();
    }

    public void Game2Results()
    {
        if (lightClicker.Game2Fail == false)
        {
            Debug.Log("You Passed Game 2!");
        }
        if (lightClicker.Game2Fail == true)
        {
            Debug.Log("You Failed Game 2!");
        }
    }
    
}
