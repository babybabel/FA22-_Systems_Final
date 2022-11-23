using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    private Vector3 mOffset;

    private float mZCoord;

    [SerializeField] AudioSource grab;
    [SerializeField] AudioSource release;
    
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        
        grab.Play();
    }

    private void OnMouseUp()
    {
        release.Play();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
    
}
