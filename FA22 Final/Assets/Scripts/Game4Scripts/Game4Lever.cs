using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game4Lever : MonoBehaviour
{

    public Animator animLever;
    //public Animator animArm;
    public Slider slider;
    
    private float lever = 0.0f;

    private int leverCounter = 0;

    public bool Game4Fail = true;

    public ParticleSystem spark;
    
    void Start()
    {
        spark = GameObject.Find("Particle").GetComponent<ParticleSystem>();
        animLever = GetComponent<Animator>();
        //animArm = GetComponent<Animator>();
        slider.onValueChanged.AddListener((v) =>
        {
            lever = v;
        });
        
        InvokeRepeating("LeverTracker", 0f, .25f);
        
    }

    void Update()
    {

        //animArm.SetFloat("Arm", lever);
        animLever.SetFloat("Lever", lever);
        
        
    }

    void LeverTracker()
    {
        
        if (lever < 0.67 && lever > 0.57)
        {
            //Debug.Log("good!");
            leverCounter++;
            spark.Play();
        }
        
        Debug.Log(leverCounter);

        if (leverCounter == 25)
        {
            Game4Fail = false;
            Debug.Log("Pass!");
            leverCounter++;
        }
        
    }
    
}
