using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3Manager : MonoBehaviour
{

    public ButtonMatcher buttonMatcher;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;

    void Start()
    {
        buttonMatcher = GameObject.Find("buttonMaster").GetComponent<ButtonMatcher>();
    }

    public void Game3Results()
    {
        if (buttonMatcher.Game3Fail == true)
        {
            Debug.Log("You Failed Game 3!");
            failAnim.SetActive(true);
            failChime.Play();
        }
        if (buttonMatcher.Game3Fail == false)
        {
            Debug.Log("You Passed Game 3!");
            successAnim.SetActive(true);
            successChime.Play();
            Scoring.totalScore++;
        }
    }
    
}