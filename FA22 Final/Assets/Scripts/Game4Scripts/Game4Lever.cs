using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game4Lever : MonoBehaviour
{

    public Animator animLever;

    public Slider slider;
    
    private float lever = 0.0f;
    
    private float sipCupPitch;

    public int leverCounter = 0;

    public bool Game4Fail = true;

    public ParticleSystem spark;
    
    [SerializeField] AudioSource needleHit;

    [SerializeField] AudioSource sipCup;
    
    void Start()
    {
        spark = GameObject.Find("Particle").GetComponent<ParticleSystem>();
        animLever = GetComponent<Animator>();
        
        slider.onValueChanged.AddListener((v) =>
        {
            lever = v;
        });
        
        InvokeRepeating("LeverTracker", 0f, .25f);
        Invoke("NeedleStopper", 10f);

    }

    void Update()
    {

        //animArm.SetFloat("Arm", lever);
        animLever.SetFloat("Lever", lever);
        
    }

    void NeedleStopper()
    {
        needleHit.mute = true;
        sipCup.mute = true;
        spark.Stop();
    }

    void LeverTracker()
    {
        
        if (lever < 0.67 && lever > 0.57)
        {
            //Debug.Log("good!");
            leverCounter++;
            spark.Play();
            needleHit.Play();
            sipCup.Play();
            sipCupPitch += .05f;
            sipCup.pitch = sipCupPitch;
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
