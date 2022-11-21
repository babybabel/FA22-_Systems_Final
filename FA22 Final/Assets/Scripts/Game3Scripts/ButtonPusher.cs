using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPusher : MonoBehaviour
{

    public Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.Play("ButtonPush");
    }

    void Update()
    {
        
    }
}
