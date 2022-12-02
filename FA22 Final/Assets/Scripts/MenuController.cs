using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnMouseOver()
    {
        anim.SetFloat("speedMultiplier", 1.1f * Mathf.Atan(anim.GetFloat("speedMultiplier") + Time.deltaTime * 2.5f));
    }

    public void OnMouseExit()
    {
        anim.SetFloat("speedMultiplier", 0f);
    }

    public void OnMouseDown()
    {
        anim.Play("BookOpen");
    }

    public void LookUp()
    {
        
    }
    
}
