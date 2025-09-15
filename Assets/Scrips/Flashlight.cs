using UnityEngine;

public class Flashlight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Light lightSource;
    public Vector2 lightSize;
    void Start()
    {
        lightSource.areaSize = lightSize;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
