using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public Animator anim;

    public GameObject normalButton;
    public GameObject hardButton;

    public BoxCollider gemCollider;

    public GameObject logoAnim;

    [SerializeField] AudioSource gemClick;
    [SerializeField] AudioSource bookFlip;


    void Start()
    {
        anim = GetComponent<Animator>();
        
        gemCollider = GetComponent<BoxCollider>();

    }

    public void OnMouseOver()
    {
        anim.SetFloat("speedMultiplier", 1.1f * Mathf.Atan(anim.GetFloat("speedMultiplier") + Time.deltaTime * 2.5f));
    }

    public void OnMouseExit()
    {
        anim.SetFloat("speedMultiplier", 0f);
    }

    public void OnMouseDown()
    {
        anim.Play("BookOpen");
        
        

        gemCollider.size = new Vector3(0f, 0f, 0f);
        
        normalButton.SetActive(true);
        hardButton.SetActive(true);
        
        gemClick.Play();
        bookFlip.PlayDelayed(0.5f);

    }

    public void LookUp()
    {
        anim.Play("BookLookUp");
        
        logoAnim.SetActive(false);
    }
    
}
