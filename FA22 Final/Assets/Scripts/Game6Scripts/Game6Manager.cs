using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game6Manager : MonoBehaviour
{

    public CalamaxController lich;

    public Keyboard keyboard;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    [SerializeField] AudioSource evil;
    
    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;

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
            failTune.Play();
            lich.LichFail();
        }
        if (keyboard.Game6Fail == false && keyboard.Game6Fucked == false)
        {
            Debug.Log("You Passed Game 6!");
            successAnim.SetActive(true);
            successChime.Play();
            successTune.Play();
            evil.Play();
            lich.LichSuccess();
            Scoring.totalScore++;
        }
    }
    
}
