using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece1 : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (PaperDragger.droped == true)
        {
            if (collision.gameObject.name == "Puzzle Piece 1")
            {
                transform.position = collision.transform.position;
            }
        }
    }

    
}
