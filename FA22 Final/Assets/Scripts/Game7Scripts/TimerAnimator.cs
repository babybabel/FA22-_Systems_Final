using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAnimator : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TimerTime()
    {
        anim.Play("TickerTime");
    }
    
}
