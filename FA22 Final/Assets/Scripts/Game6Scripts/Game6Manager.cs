using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game6Manager : MonoBehaviour
{

    public Keyboard keyboard;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    [SerializeField] AudioSource evil;

    void Start()
    {
        keyboard = GameObject.Find("Keyboard").GetComponent<Keyboard>();
    }

    public void Game6Results()
    {
        if (keyboard.Game6Fail == true || keyboard.Game6Fucked == true)
        {
            Debug.Log("You Failed Game 6!");
            failAnim.SetActive(true);
            failChime.Play();
        }
        if (keyboard.Game6Fail == false && keyboard.Game6Fucked == false)
        {
            Debug.Log("You Passed Game 6!");
            successAnim.SetActive(true);
            successChime.Play();
            evil.Play();
            Scoring.totalScore++;
        }
    }
    
}
