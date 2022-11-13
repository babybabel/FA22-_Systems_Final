using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerSimple : MonoBehaviour
{

    public float speed;
    private Rigidbody rBody;
    
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += Vector3.right * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }
}
