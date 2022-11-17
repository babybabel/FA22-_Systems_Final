using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Manager : MonoBehaviour
{
   
    public Game4Lever Lever;
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    private void Start()
    {
        Lever = GameObject.Find("Game4Lever").GetComponent<Game4Lever>();
        //failAnim = GetComponent<Animator>();
        //successAnim = GetComponent<Animator>();
    }
    
    public void Game4Results()
    {
        if (Lever.Game4Fail == false)
        {
            Debug.Log("You Passed Game 2!");
            successAnim.SetActive(true);
        }
        if (Lever.Game4Fail == true)
        {
            Debug.Log("You Failed Game 2!");
            failAnim.SetActive(true);
        }
    }
    
}
