using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Puzzle5Failsafe : MonoBehaviour
{
    public InputField input;
    public string answer;
    public static bool solved3 = false;
    //public PlaceHolder value;

    public void checkinput(string s)
    {
        s=s.ToUpper();
        if (s == answer)
        {
            solved3 = true;
            Debug.Log("Correct");
        }
        return;
    }

    public void Validate()
    {
        checkinput(input.text);
    }
}
