using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyAnimator : MonoBehaviour
{

    public Animator anim;

    [SerializeField] AudioSource kittySteam;
    [SerializeField] AudioSource kittyPoke;
    [SerializeField] AudioSource kittyLower;
    [SerializeField] AudioSource kittyNya;


    [SerializeField] float kittyPitch;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    public void KittyAnimateUp()
    {
        anim.Play("KittyJump");
        kittySteam.Play();
    }

    public void KittyAnimateDown()
    {
        anim.Play("KittyDuck");
        kittyLower.Play();
    }

    public void KittySquelch()
    {
        kittyNya.pitch = kittyPitch;
        anim.Play("KittySquelch");
        kittyPoke.Play();
        kittyNya.Play();
    }
    
}
