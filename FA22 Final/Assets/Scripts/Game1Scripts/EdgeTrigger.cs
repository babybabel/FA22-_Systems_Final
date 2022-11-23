using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeTrigger : MonoBehaviour
{
    
    public bool Game1Fail = false;

    [SerializeField] AudioSource fall;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BeltObjectA"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
            fall.Play();
        }

        if (other.CompareTag("BeltObjectB"))
        {
            Debug.Log("Pass");
            fall.Play();
        }
    }
}