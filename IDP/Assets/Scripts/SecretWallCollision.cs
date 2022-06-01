using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallCollision : MonoBehaviour
{
    public GameObject background;
    public GameObject pathcode;
    public GameObject player;
    public GameObject act2;
    public GameObject act3;
    public static bool pathlight = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 6)
        {
            background.transform.position = new Vector3 (100,0,0);
            pathcode.transform.position = new Vector3 (0,0,0);
            player.transform.position = new Vector3 (0,100,0);
            SecretWallCollision.pathlight = true;
        }
        if (Begining.puzzlenumber == 7)
        {
            act2.transform.position = new Vector3 (100,0,0);
            act3.transform.position = new Vector3(0,0,0);
        }
    }
}
