using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1ManagerHard : MonoBehaviour
{
    public FunnelTriggerHard funnelTrigger;
    public EdgeTriggerHard edgeTrigger;
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;

    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;

    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;
    
    public CalamaxController lich;

    private void Start()
    {
        funnelTrigger = GameObject.Find("FunnelTrigger").GetComponent<FunnelTriggerHard>();
        edgeTrigger = GameObject.Find("EdgeTrigger").GetComponent<EdgeTriggerHard>();
    }

    public void Game1Results()
    {
        if (funnelTrigger.Game1Fail == false && edgeTrigger.Game1Fail == false)
        {
            Debug.Log("You Passed Game 1!");
            successAnim.SetActive(true);
            successChime.Play();
            successTune.Play();
            Scoring.totalScore++;
            lich.LichSuccess();
        }
        if (funnelTrigger.Game1Fail == true || edgeTrigger.Game1Fail == true)
        {
            Debug.Log("You Failed Game 1!");
            failAnim.SetActive(true);
            failChime.Play();
            failTune.Play();
            lich.LichFail();
        }
    }
    
}
