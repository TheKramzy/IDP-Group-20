using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClicker : MonoBehaviour
{
    public GameObject shelves;
    public GameObject magbox;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Mag Collider")
                {
                    Begining.puzzlenumber = 3;
                    shelves.transform.position = new Vector3 (100,0,0);
                    magbox.transform.position = new Vector3 (0,0,0);
                }
            }
        }
    }
}
