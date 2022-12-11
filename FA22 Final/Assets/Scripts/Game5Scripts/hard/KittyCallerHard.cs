using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyCallerHard : MonoBehaviour
{

    public KittyAnimator[] kittyArr;
    public GameObject[] kittyCols;

    public int kittyCounter;

    public bool Game5Fail = true;

    
    
    public void KittyCount()
    {
        kittyCounter++;
        Debug.Log(kittyCounter);
    }

    private void Update()
    {
        if (kittyCounter == 15)
        {
            Game5Fail = false;
        }
    }

    //kitty 0
    void CallKitty0()
    {
        kittyCols[0].gameObject.SetActive(true);
        kittyArr[0].KittyAnimateUp();
    }

    void CloseKitty0()
    {
        kittyCols[0].gameObject.SetActive(false);
    }
    
    //kitty1
    
    void CallKitty1()
    {
        kittyCols[1].gameObject.SetActive(true);
        kittyArr[1].KittyAnimateUp();
    }

    void CloseKitty1()
    {
        kittyCols[1].gameObject.SetActive(false);
    }
    
    //kitty2
    
    void CallKitty2()
    {
        kittyCols[2].gameObject.SetActive(true);
        kittyArr[2].KittyAnimateUp();
    }

    void CloseKitty2()
    {
        kittyCols[2].gameObject.SetActive(false);
    }
    
    //kitty2
    
    void CallKitty3()
    {
        kittyCols[3].gameObject.SetActive(true);
        kittyArr[3].KittyAnimateUp();
    }

    void CloseKitty3()
    {
        kittyCols[3].gameObject.SetActive(false);
    }

    
    
    
}
