using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public CalamaxController lich;

    public KeyPresser[] key;

    //private bool[] keyCheck = new bool[]{false};
    
    private bool[] charFilled = new bool[4]{false, false, false, false};

    public bool Game6Fail = true;
    public bool Game6Fucked = false;

    public Material[] compScreenMat;

    public GameObject compScreen;

    void Start()
    {
        key = GameObject.Find("KeyboardKey").GetComponents<KeyPresser>();
    }
    
    void Update()
    {

        if ((charFilled[0] == false || charFilled[1] == false || charFilled[2] == false) && charFilled[3] == true)
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");

        }
        if ((charFilled[0] == false || charFilled[1] == false) && charFilled[2] == true)
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");

        }
        if ((charFilled[0] == false) && charFilled[1] == true)
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");

        }

        
    }

    public void KeyPressedQ()
    {
        Debug.Log("The Q key has been pressed");
            Game6Fucked = true;
            Debug.Log("you fucked up");
            lich.Lich4Bubble_Game6();
    }
    public void KeyPressedW()
    {
        Debug.Log("The W key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedE()
    {
        Debug.Log("The E key has been pressed");
        //checking for the first character
        if (charFilled[0] == false)
        {
            charFilled[0] = true;

            compScreen.GetComponent<MeshRenderer>().material = compScreenMat[0];

        }
        else
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");
            lich.Lich4Bubble_Game6();
        }
    }
    public void KeyPressedR()
    {
        Debug.Log("The R key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedT()
    {
        Debug.Log("The T key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedY()
    {
        Debug.Log("The Y key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedU()
    {
        Debug.Log("The U key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedI()
    {
        Debug.Log("The I key has been pressed");
        //checking for the third character
        if (charFilled[2] == false)
        {
            charFilled[2] = true;
            
            compScreen.GetComponent<MeshRenderer>().material = compScreenMat[2];

        }
        else
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");
            lich.Lich4Bubble_Game6();
        }
    }
    public void KeyPressedO()
    {
        Debug.Log("The O key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedP()
    {
        Debug.Log("The P key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedA()
    {
        Debug.Log("The A key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedS()
    {
        Debug.Log("The S key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedD()
    {
        Debug.Log("The D key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedF()
    {
        Debug.Log("The F key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedG()
    {
        Debug.Log("The G key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedH()
    {
        Debug.Log("The H key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedJ()
    {
        Debug.Log("The J key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedK()
    {
        Debug.Log("The K key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedL()
    {
        Debug.Log("The L key has been pressed");
        //checking for the fourth character
        if (charFilled[3] == false)
        {
            charFilled[3] = true;
            Game6Fail = false;
            Debug.Log("you did it!");
            
            compScreen.GetComponent<MeshRenderer>().material = compScreenMat[3];
        }
        else
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");
            lich.Lich4Bubble_Game6();
        }
    }
    public void KeyPressedZ()
    {
        Debug.Log("The Z key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedX()
    {
        Debug.Log("The X key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedC()
    {
        Debug.Log("The C key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedV()
    {
        Debug.Log("The V key has been pressed");
        //checking for the second character
        if (charFilled[1] == false)
        {
            charFilled[1] = true;
            
            compScreen.GetComponent<MeshRenderer>().material = compScreenMat[1];

        }
        else
        {
            Game6Fucked = true;
            Debug.Log("you fucked up");
            lich.Lich4Bubble_Game6();
        }
    }
    public void KeyPressedB()
    {
        Debug.Log("The B key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedN()
    {
        Debug.Log("The N key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }
    public void KeyPressedM()
    {
        Debug.Log("The M key has been pressed");
        Game6Fucked = true;
        Debug.Log("you fucked up");
        lich.Lich4Bubble_Game6();
    }

}
