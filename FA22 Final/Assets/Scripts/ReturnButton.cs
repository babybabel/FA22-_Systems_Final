using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{

    public GameObject fadetoblack;

    [SerializeField] AudioSource buttonclick;
    [SerializeField] AudioSource buttonwhoosh;
    
    private void OnMouseDown()
    {
        Invoke("SceneSwap", 2f);
        buttonclick.Play();
        buttonwhoosh.Play();
        fadetoblack.SetActive(true);
    }

    void SceneSwap()
    {
        SceneManager.LoadScene("SceneTitle");
    }
}
