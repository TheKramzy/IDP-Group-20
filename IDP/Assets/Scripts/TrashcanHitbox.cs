using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashcanHitbox : MonoBehaviour
{
    public GameObject background;
    public GameObject papertray;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 4)
        {
            background.transform.position = new Vector3 (100,0,0);
            papertray.transform.position = new Vector3 (0,0,0);
            player.transform.position = new Vector3 (0,100,0);
        }
    }
}
