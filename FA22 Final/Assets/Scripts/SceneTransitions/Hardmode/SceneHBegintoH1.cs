using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHBegintoH1 : MonoBehaviour
{
    public void LoadSceneH1()
    {
        SceneManager.LoadScene("SceneH1");
        Scoring.totalScore = 0;
    }
}
