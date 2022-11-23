using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightClicker : MonoBehaviour
{

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
            
            Debug.Log("clicked");

            clickTracker += 1;

            anim.Play("IgnitionMinor");
            
        }

        if (clickTracker == 20)
        {
            
            light.Play();
            lit.Play();
            
            anim.Play("IgnitionMajor");
            
            Debug.Log("Pass");
            
            clickTracker += 1;

            Game2Fail = false;

        }

        if (clickTracker > 20)
        {
            
            anim.Play("IgnitionOver");
            
            Game2Fail = false;

        }
        
    }
    
}
