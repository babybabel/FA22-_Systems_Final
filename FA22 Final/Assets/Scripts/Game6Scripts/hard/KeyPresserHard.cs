using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPresserHard : MonoBehaviour
{

    public Animator anim;

    public string keycode;

    public bool keycodePressed = false;

    public KeyboardHard keyboard;
    
    [SerializeField] AudioSource keySpeak;
    [SerializeField] AudioSource keyClick;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void OnMouseDown()
    {
        anim.Play("KeyPress");

        keySpeak.PlayDelayed(0.1f);
        
        keyClick.Play();
        
        if (keycode == "Q")
        {
            keyboard.KeyPressedQ();
        }
        if (keycode == "W")
        {
            keyboard.KeyPressedW();
        }
        if (keycode == "E")
        {
            keyboard.KeyPressedE();
        }
        if (keycode == "R")
        {
            keyboard.KeyPressedR();
        }
        if (keycode == "T")
        {
            keyboard.KeyPressedT();
        }
        if (keycode == "Y")
        {
            keyboard.KeyPressedY();
        }
        if (keycode == "U")
        {
            keyboard.KeyPressedU();
        }
        if (keycode == "I")
        {
            keyboard.KeyPressedI();
        }
        if (keycode == "O")
        {
            keyboard.KeyPressedO();
        }
        if (keycode == "P")
        {
            keyboard.KeyPressedP();
        }
        if (keycode == "A")
        {
            keyboard.KeyPressedA();
        }
        if (keycode == "S")
        {
            keyboard.KeyPressedS();
        }
        if (keycode == "D")
        {
            keyboard.KeyPressedD();
        }
        if (keycode == "F")
        {
            keyboard.KeyPressedF();
        }
        if (keycode == "G")
        {
            keyboard.KeyPressedG();
        }
        if (keycode == "H")
        {
            keyboard.KeyPressedH();
        }
        if (keycode == "J")
        {
            keyboard.KeyPressedJ();
        }
        if (keycode == "K")
        {
            keyboard.KeyPressedK();
        }
        if (keycode == "L")
        {
            keyboard.KeyPressedL();
        }
        if (keycode == "Z")
        {
            keyboard.KeyPressedZ();
        }
        if (keycode == "X")
        {
            keyboard.KeyPressedX();
        }
        if (keycode == "C")
        {
            keyboard.KeyPressedC();
        }
        if (keycode == "V")
        {
            keyboard.KeyPressedV();
        }
        if (keycode == "B")
        {
            keyboard.KeyPressedB();
        }
        if (keycode == "N")
        {
            keyboard.KeyPressedN();
        }
        if (keycode == "M")
        {
            keyboard.KeyPressedM();
        }
        
    }

    void Update()
    {
        
    }
}
