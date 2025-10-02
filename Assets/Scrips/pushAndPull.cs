using JetBrains.Annotations;
using System;
using UnityEngine;

public class pushAndPull : MonoBehaviour
{
    
    public Camera playerCamera;
    public float maxDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, playerCamera.transform.TransformDirection(Vector3.forward) * 10, Color.red);
        if (Input.GetButtonDown("Fire1"))
        {
            
        }
    }

    void pull()
    {
        
    }

    void push()
    {

    }
}
