using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game5Manager : MonoBehaviour
{
    public CalamaxController lich;

    public KittyCaller kittyCaller;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    
    void Start()
    {
        kittyCaller = GameObject.Find("KittyContainer").GetComponent<KittyCaller>();
    }

    public void Game5Results()
    {
        if (kittyCaller.Game5Fail == false)
        {
            Debug.Log("You Passed Game 5!");
            successAnim.SetActive(true);
            successChime.Play();
            lich.LichSuccess();
            Scoring.totalScore++;
        }
        if (kittyCaller.Game5Fail == true)
        {
            Debug.Log("You Failed Game 5!");
            failAnim.SetActive(true);
            failChime.Play();
            lich.LichFail();
        }
    }
    
}
