using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitCollisionActivation : MonoBehaviour
{
    public GameObject circuit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 1)
        {
            GameObject c = circuit as GameObject;
            c.transform.position = new Vector3 (0,0,0);
            Begining.cutscene = true;
        }
    }
} //class
