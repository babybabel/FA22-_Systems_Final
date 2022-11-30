using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightClicker : MonoBehaviour
{

    public CalamaxController lich;

    public GameObject burner;
    
    private int clickTracker = 0;

    public Animator anim;

    public bool Game2Fail = true;

    [SerializeField] AudioSource click;
    [SerializeField] AudioSource light;
    [SerializeField] AudioSource lit;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        
        click.Play();
        

        if (clickTracker < 20)
        {
            
            lich.Lich3Click();

            Debug.Log("clicked");

            clickTracker += 1;

            anim.Play("IgnitionMinor");
            
        }

        if (clickTracker == 20)
        {
            
            light.Play();
            lit.Play();
            lich.Lich1Click();
            
            anim.Play("IgnitionMajor");
            
            Debug.Log("Pass");
            
            clickTracker += 1;

            Game2Fail = false;

            burner.SetActive(true);

        }

        if (clickTracker > 20)
        {
            lich.Lich1Click();

            anim.Play("IgnitionOver");
            
            Game2Fail = false;

        }
        
    }
    
}
