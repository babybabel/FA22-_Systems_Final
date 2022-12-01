using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTex : MonoBehaviour
{

    public float ScrollX;
    public float ScrollY;

    private MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset = new Vector2(Time.time * ScrollX, Time.time * ScrollY);
    }
}
