using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEBegintoE1 : MonoBehaviour
{
    public void LoadSceneE1()
    {
        SceneManager.LoadScene("SceneE1");
        Scoring.totalScore = 0;
    }
}
