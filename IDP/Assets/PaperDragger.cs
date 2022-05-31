using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperDragger : MonoBehaviour
{
    public static bool droped = true;
    public static bool Piece1 = false;
    public static bool Piece2 = false;
    public static bool Piece3 = false;
    public static bool Piece4 = false;
    public static bool Piece5 = false;
    public GameObject background;
    public GameObject papertray;
    public GameObject player;

    void OnMouseDrag(){
        transform.position = GetMousePos();
        droped = false;
    }

    Vector3 GetMousePos(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            droped = true;
        }

        if (Piece1 == true && Piece2 == true && Piece3 == true && Piece4 == true && Piece5 == true)
        {
            Debug.Log("connected");
            if (Begining.puzzlenumber == 4)
            {
                background.transform.position = new Vector3 (0,0,0);
                papertray.transform.position = new Vector3 (100,0,0);
                player.transform.position = new Vector3 (0,0,0);
                Begining.puzzlenumber = 5;

            }
        }
    }

}
