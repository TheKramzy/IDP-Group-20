using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece2 : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (PaperDragger.droped == true)
        {
            if (collision.gameObject.name == "Puzzle Piece 2")
            {
                transform.position = collision.transform.position;
                PaperDragger.Piece2 = true;
            }
        }
    }
}
