using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyCaller : MonoBehaviour
{

    public KittyAnimator[] kittyArr;
    public GameObject[] kittyCols;
    
    
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    void CallKitty1()
    {

        kittyCols[0].gameObject.SetActive(true);
        kittyArr[0].KittyAnimateUp();

    }

    void KittyClose1()
    {
        
        kittyCols[0].gameObject.SetActive(false);
        //kittyArr[0].KittyAnimateDown();

    }
    
    
}
