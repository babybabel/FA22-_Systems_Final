using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyClicker : MonoBehaviour
{

    public KittyAnimator kittyAnimator;
    
    public int KittyCounter;

    void Start()
    {
        //kittyCaller = GameObject.Find("KittyContainer").GetComponent<KittyCaller>();
    }

    public void OnMouseDown()
    {
        gameObject.SetActive(false);
        KittyCounter++;
        kittyAnimator.KittySquelch();
        Debug.Log(KittyCounter);
        //Debug.Log("Clicked!");

    }

}
