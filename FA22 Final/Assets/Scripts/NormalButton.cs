using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalButton : MonoBehaviour
{

    public Material[] material;

    public GameObject normalButton;

    public MenuController introbook;

    [SerializeField] AudioSource selectTone;
    [SerializeField] AudioSource selectClick;

    public void OnMouseDown()
    {
        normalButton.GetComponent<Renderer>().material = material[1];
        
        introbook.LookUp();
        
        selectTone.Play();
        selectClick.Play();
        
        Invoke("EasyPath", 2f);
    }

    public void EasyPath()
    {
        SceneManager.LoadScene("SceneEbegin 1");
    }
}
