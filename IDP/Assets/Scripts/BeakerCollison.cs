using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakerCollison : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 5)
        {
            Begining.cutscene = true;
        }
    }
}
