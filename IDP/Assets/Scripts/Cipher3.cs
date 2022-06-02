using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cipher3 : MonoBehaviour
{
    public GameObject Act1;
    public GameObject Player;
    public GameObject Act2Cutscene;
    public GameObject Keypad;
    public GameObject InputField;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 3)
        {
            Keypad.transform.position = new Vector3(0,0,0);
            InputField.transform.position = new Vector3(-100.75f,0.5f,0);
        }
    }
    public void Update()
    {
       if (Begining.puzzlenumber == 3)
        {
            if (Puzzle3Failsafe.solved3 == true)
            {
                Act1.transform.position = new Vector3(100,0,0);
                Player.transform.position = new Vector3(100,0,0);
                Act2Cutscene.transform.position = new Vector3(0,0,0);
                Begining.cutscene = true;

                Begining.puzzlenumber = 4;
            }
        } 
    }
}
