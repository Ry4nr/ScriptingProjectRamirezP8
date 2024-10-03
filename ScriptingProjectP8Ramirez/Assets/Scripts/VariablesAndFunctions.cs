using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type integer 
    int MyInt = 7;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run myInt thru my function to multiply it bye two 
        MyInt = MultiplyByTwo(MyInt);

        //I am going to print the results to the console
        Debug.Log(MyInt);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Creating a function that takes a int parametere and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        //creating a variable to store my results
        int results;
        //multiplying the passes parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }

}