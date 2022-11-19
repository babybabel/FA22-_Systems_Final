using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game5Manager : MonoBehaviour
{

    public KittyCaller kittyCaller;
    
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    void Start()
    {
        kittyCaller = GameObject.Find("KittyContainer").GetComponent<KittyCaller>();

    }

    public void Game5Results()
    {
        if (kittyCaller.Game5Fail == false)
        {
            Debug.Log("You Passed Game 5!");
            successAnim.SetActive(true);
        }
        if (kittyCaller.Game5Fail == true)
        {
            Debug.Log("You Failed Game 5!");
            failAnim.SetActive(true);
        }
    }
    
}
