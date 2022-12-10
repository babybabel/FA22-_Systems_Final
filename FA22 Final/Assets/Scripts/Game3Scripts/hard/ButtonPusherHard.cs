using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPusherHard : MonoBehaviour
{

    public Animator anim;

    public ButtonMatcherHard match;

    public int buttonCode;
    
    [SerializeField] AudioSource buttonClick;

    public Material[] buttonSwitch;

    public GameObject buttonMatch;

    private bool toggle = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {

        anim.Play("ButtonPush");
        
        buttonClick.Play();
        
        if (!toggle)
        {
            buttonMatch.GetComponent<SkinnedMeshRenderer>().material = buttonSwitch[1];
            toggle = true;
        }
        else
        {
            buttonMatch.GetComponent<SkinnedMeshRenderer>().material = buttonSwitch[0];
            toggle = false;
        }


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
