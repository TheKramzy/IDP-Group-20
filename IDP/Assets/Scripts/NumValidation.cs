using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumValidation : MonoBehaviour
{
    public InputField answer;
    //public PlaceHolder value;

    void checkinput(string s)
    {
        int number;
        bool returnValue = Int32.TryParse(s, out number);
        if (returnValue == false || (1 > number || 5 < number))
        {
           answer.text = "";
           //answer.Placeholder. = "Enter a number please!";
        }
        return;
    }

    public void Validate()
    {
        checkinput(answer.text);
    }
}
