using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenHard : MonoBehaviour
{

    public CalamaxController lich;

    public TimerAnimator timer;

    public Animator ovenanim;

    public bool isReady = false;

    public bool Game7Fail = true;

    public bool Game7Fucked = false;

    [SerializeField] AudioSource ovenDoor;
    [SerializeField] AudioSource ovenDing;
    [SerializeField] AudioSource ovenTick;
    [SerializeField] AudioSource ovenAmbient;

    public Material[] ovenlight;

    public GameObject ovenlightmesh;

    
    void Start()
    {
        ovenanim = GetComponent<Animator>();
        Invoke("BecomeReady", 7f);
        Invoke("NoLongerReady", 7.75f);
        
        
    }

    void BecomeReady()
    {
        isReady = true;
        timer.TimerTime();
        Debug.Log("Now!");
        ovenlightmesh.GetComponent<MeshRenderer>().material = ovenlight[1];
        ovenAmbient.Stop();
        ovenTick.mute = true;
        ovenDing.Play();
    }

    void NoLongerReady()
    {
        isReady = false;
        Debug.Log("Stop!");
    }

    private void OnMouseDown()
    {
        ovenanim.Play("OpenOven");
        ovenDoor.Play();

        if (isReady == true)
        {
            Debug.Log("Got it!");
            Game7Fail = false;
            lich.Lich3();
        }

        if (isReady == false)
        {
            Debug.Log("You fucked up!");
            Game7Fucked = true;
            lich.Lich4Fail();
        }
    }
}
