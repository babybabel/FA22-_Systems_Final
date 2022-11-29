using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalamaxController : MonoBehaviour
{

    public Animator lich; 
    
    void Start()
    {
        lich = GetComponent<Animator>();
    }

    public void LichFail()
    {
        lich.Play("lichfail");
    }

    public void LichSuccess()
    {
        lich.Play("lichsuccess");
    }

    public void LichSip()
    {
        lich.Play("lichsip");
    }

    public void Lich1()
    {
        lich.Play("lich1");
    }

    public void Lich1Click()
    {
        lich.Play("lich1click");
    }

    public void Lich1Sat()
    {
        lich.Play("lich1sat");
    }
    
    public void Lich2()
    {
        lich.Play("lich2");
    }

    public void Lich2Still()
    {
        lich.Play("lich2still");
    }

    public void LichPoke()
    {
        lich.Play("lichpoke");
    }

    public void Lich3()
    {
        lich.Play("lich3");
    }
    
    public void Lich3Bubble()
    {
        lich.Play("lich3bubble");
    }

    public void Lich4Bubble_Game1()
    {
        lich.Play("lich4failbubble_game1");
    }

    public void Lich4Bubble_Game6()
    {
        lich.Play("lich4failbubble_game6");
    }

    public void Lich3Click()
    {
        lich.Play("lich3click");
    }

    public void Lich3Grab()
    {
        lich.Play("lich3grab");
    }

    public void Lich3Def()
    {
        lich.Play("lich3def");
    }

    public void Lich4Fail()
    {
        lich.Play("lich4fail");
    }

    public void Lich5Bubble()
    {
        lich.Play("lich5bubble");
    }

    public void LichResults()
    {
        lich.Play("lichresults");
    }
    
}
