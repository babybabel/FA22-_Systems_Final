using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMatcher : MonoBehaviour
{

    private bool[] toggle = new bool[7]{false, false, false, false, false, false, false};

    public bool Game3Fail = true;
    
    private void Update()
    {
        if (toggle[0] == true && toggle[1] == false && toggle[2] == true && toggle[3] == true && toggle[4] == false &&
            toggle[5] == false && toggle[6] == true)
        {
            Game3Fail = false;
        }
    }

    public void buttonPress0()
    {
        if (!toggle[0])
        {
            toggle[0] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[0] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress1()
    {
        if (!toggle[1])
        {
            toggle[1] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[1] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress2()
    {
        if (!toggle[2])
        {
            toggle[2] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[2] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress3()
    {
        if (!toggle[3])
        {
            toggle[3] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[3] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress4()
    {
        if (!toggle[4])
        {
            toggle[4] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[4] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress5()
    {
        if (!toggle[5])
        {
            toggle[5] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[5] = false;
            Debug.Log("false");
        }
    }
    
    public void buttonPress6()
    {
        if (!toggle[6])
        {
            toggle[6] = true;
            Debug.Log("on");
        }
        else
        {
            toggle[6] = false;
            Debug.Log("false");
        }
    }
    
}
