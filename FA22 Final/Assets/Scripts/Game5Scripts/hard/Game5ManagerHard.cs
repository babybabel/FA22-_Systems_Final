using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game5ManagerHard : MonoBehaviour
{
    public CalamaxController lich;

    public KittyCallerHard kittyCaller;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    
    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;
    
    void Start()
    {
        kittyCaller = GameObject.Find("KittyContainer").GetComponent<KittyCallerHard>();
    }

    public void Game5Results()
    {
        if (kittyCaller.Game5Fail == false)
        {
            Debug.Log("You Passed Game 5!");
            successAnim.SetActive(true);
            successChime.Play();
            lich.LichSuccess();
            successTune.Play();
            Scoring.totalScore++;
        }
        if (kittyCaller.Game5Fail == true)
        {
            Debug.Log("You Failed Game 5!");
            failAnim.SetActive(true);
            failChime.Play();
            failTune.Play();
            lich.LichFail();
        }
    }
    
}
