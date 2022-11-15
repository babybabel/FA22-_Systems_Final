using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Manager : MonoBehaviour
{

    public LightClicker lightClicker;
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    private void Start()
    {
        lightClicker = GameObject.Find("LightClicker").GetComponent<LightClicker>();
        //failAnim = GetComponent<Animator>();
        //successAnim = GetComponent<Animator>();
    }

    public void Game2Results()
    {
        if (lightClicker.Game2Fail == false)
        {
            Debug.Log("You Passed Game 2!");
            successAnim.SetActive(true);
        }
        if (lightClicker.Game2Fail == true)
        {
            Debug.Log("You Failed Game 2!");
            failAnim.SetActive(true);
        }
    }
    
}
