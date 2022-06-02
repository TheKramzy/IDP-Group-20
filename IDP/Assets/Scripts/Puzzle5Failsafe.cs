using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Puzzle5Failsafe : MonoBehaviour
{
    public InputField input;
    public string answer;
    public static int list = 0;
    //public PlaceHolder value;

    public void checkinput(string s)
    {
        s=s.ToUpper();
        if (s == answer)
        {
            list += 1;
            Debug.Log("Correct");
        }
        return;
    }

    public void Validate()
    {
        checkinput(input.text);
    }
}
