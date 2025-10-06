using JetBrains.Annotations;
using System;
using UnityEngine;

public class pushAndPull : MonoBehaviour
{
    
    public Camera playerCamera;
    public float maxDistance;
    public LayerMask layerMask;
    public Transform headPos;
    public Transform camRoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Physics.Raycast(headPos.position, playerCamera.transform.TransformDirection(Vector3.forward) * 10, maxDistance, layerMask))
            {
                pull();
            }     
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (Physics.Raycast(headPos.position, playerCamera.transform.TransformDirection(Vector3.forward) * 10, maxDistance, layerMask))
            {
                push();
            }
        }
    }

    void pull()
    {
        Ray ray = new Ray(headPos.position, playerCamera.transform.TransformDirection(Vector3.forward) * 10);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){
            hit.transform.GetComponent<Rigidbody>().AddForce(-camRoot.transform.forward);
            Debug.Log("Hitt");
        }

        
        
        
    }

    void push()
    {
        Ray ray = new Ray(headPos.position, playerCamera.transform.TransformDirection(Vector3.forward) * 10);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 pushAngle = Quaternion.AngleAxis(-90, camRoot.right) * camRoot.transform.forward;
             
            hit.transform.GetComponent<Rigidbody>().AddForce(pushAngle);
            Debug.Log("Hitt");
        }
    }
    
}
