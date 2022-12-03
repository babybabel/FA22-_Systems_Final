using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Manager : MonoBehaviour
{

    public CalamaxController lich;

    public LightClicker lightClicker;
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    
    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;

    private void Start()
    {
        lightClicker = GameObject.Find("LightClicker").GetComponent<LightClicker>();
    }

    public void Game2Results()
    {
        if (lightClicker.Game2Fail == false)
        {
            Debug.Log("You Passed Game 2!");
            successAnim.SetActive(true);
            successChime.Play();
            successTune.Play();
            Scoring.totalScore++;
            lich.LichSuccess();
        }
        if (lightClicker.Game2Fail == true)
        {
            Debug.Log("You Failed Game 2!");
            failAnim.SetActive(true);
            failChime.Play();
            failTune.Play();
            lich.LichFail();
        }
    }
    
}
