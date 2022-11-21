using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game7Manager : MonoBehaviour
{

    public Oven oven;

    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;

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
        }
        if (oven.Game7Fail == false && oven.Game7Fucked == false)
        {
            Debug.Log("You Passed Game 7!");
            successAnim.SetActive(true);
            Scoring.totalScore++;
            Debug.Log(Scoring.totalScore);
        }
    }

}
