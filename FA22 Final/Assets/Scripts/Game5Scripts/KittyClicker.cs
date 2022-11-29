using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyClicker : MonoBehaviour
{

    public CalamaxController lich;

    public KittyAnimator kittyAnimator;
    public KittyCaller kittyCaller;
    
    void Start()
    {
        //kittyCaller = GameObject.Find("KittyContainer").GetComponent<KittyCaller>();
    }

    public void OnMouseDown()
    {
        gameObject.SetActive(false);
        kittyAnimator.KittySquelch();
        kittyCaller.KittyCount();
        Debug.Log("Clicked!");
        lich.LichPoke();
    }

}
