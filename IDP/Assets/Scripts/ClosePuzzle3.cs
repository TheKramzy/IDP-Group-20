using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePuzzle3 : MonoBehaviour
{
    public GameObject Keypad;
    public GameObject InputField;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 3)
        {
            Keypad.transform.position = new Vector3(100,0,0);
            InputField.transform.position = new Vector3(1000,0,0);
        }
    }
}
