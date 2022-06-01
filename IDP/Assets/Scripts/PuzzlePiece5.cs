using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece5 : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (PaperDragger.droped == true)
        {
            if (collision.gameObject.name == "Puzzle Piece 5")
            {
                transform.position = collision.transform.position;
                PaperDragger.Piece5 = true;
            }
        }
    }
}
