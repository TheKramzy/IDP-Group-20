using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterCollision : MonoBehaviour
{
    public GameObject poster;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 2)
        {
            poster.transform.position = new Vector3 (0,0,0);
        }
    }
}
