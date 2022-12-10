using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelTriggerHard : MonoBehaviour
{
    public bool Game1Fail = false;

    [SerializeField] AudioSource plop;

    public CalamaxController lich;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BeltObjectA"))
        {
            Debug.Log("Pass");
            plop.Play();
        }

        if (other.CompareTag("BeltObjectB"))
        {
            Debug.Log("Pass");
            plop.Play();
        }
        
        if (other.CompareTag("BeltObjectC"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
            plop.Play();
            lich.Lich4Bubble_Game1();
        }
        
        if (other.CompareTag("BeltObjectD"))
        {
            Debug.Log("Pass");
            plop.Play();
        }
    }
}
