using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCircuitActivation : MonoBehaviour
{
    public GameObject circuit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject c = circuit as GameObject;
        c.transform.position = new Vector3 (100,0,0);
    }
}
