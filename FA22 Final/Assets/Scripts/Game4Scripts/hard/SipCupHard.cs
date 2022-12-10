using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SipCupHard : MonoBehaviour
{

    public Game4LeverHard lever;
    
    private float cupFill;
    
    public SkinnedMeshRenderer cup;

    void Start()
    {
        lever = GameObject.Find("needlelever").gameObject.GetComponent<Game4LeverHard>();
        cup = GetComponent<SkinnedMeshRenderer>();
    }

    void Update()
    {
        cupFill = 100 - (lever.leverCounter * 3);
        cup.SetBlendShapeWeight(0, cupFill);
    }
}
