using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class YesNoValidation : MonoBehaviour
{
    public InputField answer;
    //public PlaceHolder value;

    void checkstr(string s)
    {
        if (s != "YES" && s != "NO")
        {
            answer.text = "";
            //answer.Placeholder. = "Enter a number please!";
        }
        return;
    }

    public void ValidateYesNo()
    {
        checkstr(answer.text.ToUpper());
    }
}