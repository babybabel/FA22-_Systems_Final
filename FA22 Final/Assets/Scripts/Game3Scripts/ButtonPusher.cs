using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPusher : MonoBehaviour
{

    public Animator anim;

    public ButtonMatcher match;

    public int buttonCode;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {

        anim.Play("ButtonPush");

        if (buttonCode == 0)
        {
            match.buttonPress0();
        }
        
        
        
    }

}
