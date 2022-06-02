using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Puzzle3Failsafe : MonoBehaviour
{

    public InputField input;
    public string answer = "I LOVE RATS";
    public static bool solved3 = false;
    public GameObject InputField;
    
    //public PlaceHolder value;

    public void checkinput(string s)
    {
        s=s.ToUpper();
        if (s == answer)
        {
            solved3 = true;
            InputField.transform.position = new Vector3(1000,0,0);
            Debug.Log("Correct");
        }
        return;
    }

    public void Validate()
    {
        checkinput(input.text);
    }
}
