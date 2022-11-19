using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{

    public KeyPresser[] key;
    
    void Start()
    {
        key = GameObject.Find("KeyboardKey").GetComponents<KeyPresser>();
    }

    public void KeyPressedQ()
    {
        Debug.Log("The Q key has been pressed");
    }
    public void KeyPressedW()
    {
        Debug.Log("The W key has been pressed");
    }
    public void KeyPressedE()
    {
        Debug.Log("The E key has been pressed");
    }
    public void KeyPressedR()
    {
        Debug.Log("The R key has been pressed");
    }
    public void KeyPressedT()
    {
        Debug.Log("The T key has been pressed");
    }
    public void KeyPressedY()
    {
        Debug.Log("The Y key has been pressed");
    }
    public void KeyPressedU()
    {
        Debug.Log("The U key has been pressed");
    }
    public void KeyPressedI()
    {
        Debug.Log("The I key has been pressed");
    }
    public void KeyPressedO()
    {
        Debug.Log("The O key has been pressed");
    }
    public void KeyPressedP()
    {
        Debug.Log("The P key has been pressed");
    }
    public void KeyPressedA()
    {
        Debug.Log("The A key has been pressed");
    }
    public void KeyPressedS()
    {
        Debug.Log("The S key has been pressed");
    }
    public void KeyPressedD()
    {
        Debug.Log("The D key has been pressed");
    }
    public void KeyPressedF()
    {
        Debug.Log("The F key has been pressed");
    }
    public void KeyPressedG()
    {
        Debug.Log("The G key has been pressed");
    }
    public void KeyPressedH()
    {
        Debug.Log("The H key has been pressed");
    }
    public void KeyPressedJ()
    {
        Debug.Log("The J key has been pressed");
    }
    public void KeyPressedK()
    {
        Debug.Log("The K key has been pressed");
    }
    public void KeyPressedL()
    {
        Debug.Log("The L key has been pressed");
    }
    public void KeyPressedZ()
    {
        Debug.Log("The Z key has been pressed");
    }
    public void KeyPressedX()
    {
        Debug.Log("The X key has been pressed");
    }
    public void KeyPressedC()
    {
        Debug.Log("The C key has been pressed");
    }
    public void KeyPressedV()
    {
        Debug.Log("The V key has been pressed");
    }
    public void KeyPressedB()
    {
        Debug.Log("The B key has been pressed");
    }
    public void KeyPressedN()
    {
        Debug.Log("The N key has been pressed");
    }
    public void KeyPressedM()
    {
        Debug.Log("The M key has been pressed");
    }





    void Update()
    {
        
    }
}
