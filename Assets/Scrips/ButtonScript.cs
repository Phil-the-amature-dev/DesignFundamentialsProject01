using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using System;

public class ButtonScript : PlayerActivatable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ButtonPuzzle puzzle;
    public int Id;
    public Material greenState;
    void Start()
    {
      canRepeat = false;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override protected void OnActivate()
    {
        puzzle.buttonNum += 1;
        Debug.Log(puzzle.buttonNum);
        GetComponent<Renderer>().material = greenState;

    }
}
