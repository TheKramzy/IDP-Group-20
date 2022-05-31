using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cipher3 : MonoBehaviour
{
    public GameObject Act1;
    public GameObject Act2;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Act1.transform.position = new Vector3(100,0,0);
       Act2.transform.position = new Vector3(0,0,0);
       player.transform.position= new Vector3 (-8,4,0);
    }
}
