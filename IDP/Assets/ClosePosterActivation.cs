using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePosterActivation : MonoBehaviour
{
    public GameObject poster;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        poster.transform.position = new Vector3 (100,0,0);
    }
}

