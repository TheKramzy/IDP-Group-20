using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathClicker : MonoBehaviour
{
    public int pathnumber = 0;
    public GameObject good1;
    public GameObject good2;
    public GameObject good3;
    public GameObject good4;
    public GameObject good5;
    public GameObject good6;
    public GameObject background;
    public GameObject pathcode;
    public GameObject player;
    public GameObject act2;
    public GameObject act3;
    private void Update()
    {
        if (Begining.puzzlenumber == 6 & SecretWallCollision.pathlight == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null)
                {
                    if (hit.collider.gameObject.name != "Good 1" && hit.collider.gameObject.name != "Good 2" && hit.collider.gameObject.name != "Good 3" && hit.collider.gameObject.name != "Good 4" && hit.collider.gameObject.name != "Good 5" && hit.collider.gameObject.name != "Good 6")
                    {
                        Debug.Log("reset");
                        pathnumber = 0;
                        good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                    }

                    if (hit.collider.gameObject.name == "Good 1")
                    {
                        if (pathnumber == 0)
                        {
                            good1.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                            pathnumber += 1;
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }
                
                    if (hit.collider.gameObject.name == "Good 2")
                    {
                        if (pathnumber == 1)
                        {
                            good2.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                            pathnumber += 1;
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }

                    if (hit.collider.gameObject.name == "Good 3")
                    {
                        if (pathnumber == 2)
                        {
                            good3.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                            pathnumber += 1;
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }

                    if (hit.collider.gameObject.name == "Good 4")
                    {
                        if (pathnumber == 3)
                        {
                            good4.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                            pathnumber += 1;
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }

                    if (hit.collider.gameObject.name == "Good 5")
                    {
                        if (pathnumber == 4)
                        {
                            good5.GetComponent<Renderer>().material.color = new Color(0.8f,0.8f,1);
                            pathnumber += 1;
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }

                    if (hit.collider.gameObject.name == "Good 6")
                    {
                        if (pathnumber == 5)
                        {
                            Loader.ToSurvey();
                        }
                        else
                        {
                            pathnumber = 0;
                            good1.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good2.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good3.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good4.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good5.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                            good6.GetComponent<Renderer>().material.color = new Color(100, 100, 100);
                        }
                    }
                }
            }
            
        } 
    }
}
