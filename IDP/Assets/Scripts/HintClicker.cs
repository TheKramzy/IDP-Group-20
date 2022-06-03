using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintClicker : MonoBehaviour
{
    public GameObject good1;
    public GameObject good2;
    public GameObject good3;
    public GameObject good4;
    public GameObject good5;
    public GameObject good6;
    private void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
            if (hit.collider.gameObject.name == "HintButton")
                {

                    SecretWallCollision.pathlight = false;
                    Begining.cutscene = true;
                    good1.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                    good2.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                    good3.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                    good4.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                    good5.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                    good6.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                }
            }
        }
        
    }
}
