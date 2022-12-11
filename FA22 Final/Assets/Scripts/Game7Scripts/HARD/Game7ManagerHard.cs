using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game7ManagerHard : MonoBehaviour
{

    public CalamaxController lich;

    public Oven oven;

    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;

    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    
    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;

    void Start()
    {
        oven = GameObject.Find("OvenDoor").gameObject.GetComponent<Oven>();
        
    }

    public void Game7Results()
    {
        if (oven.Game7Fail == true || oven.Game7Fucked == true)
        {
            Debug.Log("You Failed Game 7!");
            failAnim.SetActive(true);
            failChime.Play();
            failTune.Play();
            lich.LichFail();
        }
        if (oven.Game7Fail == false && oven.Game7Fucked == false)
        {
            Debug.Log("You Passed Game 7!");
            successAnim.SetActive(true);
            successChime.Play();
            successTune.Play();
            lich.LichSuccess();
            Scoring.totalScore++;
            Debug.Log(Scoring.totalScore);
        }
    }

}
