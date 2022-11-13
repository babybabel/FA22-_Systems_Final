using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BeltObjectA"))
        {
            Debug.Log("Fail");
        }

        if (other.CompareTag("BeltObjectB"))
        {
            Debug.Log("Pass");
        }
    }
}