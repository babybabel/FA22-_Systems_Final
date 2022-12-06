using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultRevealer : MonoBehaviour
{

    public GameObject[] result;

    void Start()
    {
        if (Scoring.totalScore == 0)
        {
            result[0].SetActive(true);
        } else if (Scoring.totalScore == 1)
        {
            result[1].SetActive(true);
        } else if (Scoring.totalScore == 2)
        {
            result[2].SetActive(true);
        } else if (Scoring.totalScore == 3)
        {
            result[3].SetActive(true);
        } else if (Scoring.totalScore == 4)
        {
            result[4].SetActive(true);
        } else if (Scoring.totalScore == 5)
        {
            result[5].SetActive(true);
        } else if (Scoring.totalScore == 6)
        {
            result[6].SetActive(true);
        } else if (Scoring.totalScore == 7)
        {
            result[7].SetActive(true);
        }
    }
}
