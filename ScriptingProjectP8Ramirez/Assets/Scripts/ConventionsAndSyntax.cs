using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndsyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I want to get the x location of a game object and show it on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //I want to know when a game objects y posistion is lower than 5
        if (transform.position.y <= 5f)
        {
            Debug.Log("im about to hit the ground");
        }
    }
}