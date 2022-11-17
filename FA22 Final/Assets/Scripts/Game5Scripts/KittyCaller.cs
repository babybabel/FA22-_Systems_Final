using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyCaller : MonoBehaviour
{

    public GameObject[] kittyArr;
    public GameObject[] kittyCols;
    
    void Start()
    {
        
    }

    void CallKitty1()
    {

        kittyCols[1].gameObject.SetActive(true);
        
    }
    
    
}
