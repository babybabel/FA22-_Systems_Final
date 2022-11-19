using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyAnimator : MonoBehaviour
{

    public Animator anim;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void KittyAnimateUp()
    {
        anim.Play("KittyJump");
    }

    public void KittyAnimateDown()
    {
        anim.Play("KittyDuck");
    }

    public void KittySquelch()
    {
        anim.Play("KittySquelch");
    }
    
}
