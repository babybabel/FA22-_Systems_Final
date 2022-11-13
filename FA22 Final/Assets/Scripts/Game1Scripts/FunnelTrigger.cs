using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelTrigger : MonoBehaviour
{
    public bool Game1Fail = false;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BeltObjectA"))
        {
            Debug.Log("Pass");
        }

        if (other.CompareTag("BeltObjectB"))
        {
            Debug.Log("Fail");
            Game1Fail = true;
        }
    }
}
