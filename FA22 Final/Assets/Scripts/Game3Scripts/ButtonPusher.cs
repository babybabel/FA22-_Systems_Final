using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPusher : MonoBehaviour
{

    public Animator anim;

    public ButtonMatcher match;

    public int buttonCode;
    
    [SerializeField] AudioSource buttonClick;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {

        anim.Play("ButtonPush");
        
        buttonClick.Play();

        if (buttonCode == 0)
        {
            match.buttonPress0();
        }
        
        if (buttonCode == 1)
        {
            match.buttonPress1();
        }
        
        if (buttonCode == 2)
        {
            match.buttonPress2();
        }
        
        if (buttonCode == 3)
        {
            match.buttonPress3();
        }
        
        if (buttonCode == 4)
        {
            match.buttonPress4();
        }
        
        if (buttonCode == 5)
        {
            match.buttonPress5();
        }
        
        if (buttonCode == 6)
        {
            match.buttonPress6();
        }
    }

}
