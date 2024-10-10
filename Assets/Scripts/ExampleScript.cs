using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [Header("Identification")] 
    [SerializeField] private String firstName = "John";
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am initialized!");
        Debug.Log($"My name is {firstName}");
        // ^ String interpolation, equivalent to:
        // Debug.Log("My name is " + firstName);
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
