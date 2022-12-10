using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeTriggerHard : MonoBehaviour
{
    
    public bool Game1Fail = false;

    [SerializeField] AudioSource fall;
    
    public CalamaxController lich;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BeltObjectA"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
            fall.Play();
            lich.Lich4Bubble_Game1();
        }

        if (other.CompareTag("BeltObjectB"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
            fall.Play();
            lich.Lich4Bubble_Game1();
        }
        
        if (other.CompareTag("BeltObjectC"))
        {
            Debug.Log("Pass");
            fall.Play();
        }
        
        if (other.CompareTag("BeltObjectD"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
            fall.Play();
            lich.Lich4Bubble_Game1();
        }

    }
}