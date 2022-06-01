using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public GameObject shelves;
    public GameObject magbox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (Begining.puzzlenumber == 2)
       {
            shelves.transform.position = new Vector3 (0,0,0);
       }
       if (Begining.puzzlenumber == 3)
       {
            magbox.transform.position = new Vector3 (0,0,0);
       }
    }
}
