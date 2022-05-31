using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzplePiece3 : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (PaperDragger.droped == true)
        {
            if (collision.gameObject.name == "Puzzle Piece 3")
            {
                transform.position = collision.transform.position;
                PaperDragger.Piece3 = true;
            }
        }
    }
}
