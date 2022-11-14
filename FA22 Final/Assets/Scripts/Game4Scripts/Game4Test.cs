using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Test : MonoBehaviour
{

    public Animator anim;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
        }
    }
}
