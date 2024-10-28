using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cupsInTheSInk = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheSInk > 0) 
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSInk--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
