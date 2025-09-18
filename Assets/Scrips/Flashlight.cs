using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class Flashlight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Light lightSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //toggles flashlight on or off when e is pressed. 
        if (Input.GetKeyDown("e")){
            lightSource.enabled = !lightSource.enabled;
        }
    }
}
