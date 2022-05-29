using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireClicker : MonoBehaviour
{
    public string selected = "none";
    public string rg = "disconnected";
    public string bo = "disconnected";
    public string yp = "disconnected";
    public GameObject RG;
    public GameObject BO;
    public GameObject YP;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Orange")
                {
                    if (bo == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "orange";
                            Debug.Log(selected);
                        }

                        if (selected == "blue")
                        {
                            bo = "connected";
                            selected = "none";
                            GameObject bwire = BO as GameObject;
                            bwire.transform.position = new Vector3 (-2.59f,0.84f,0);
                        }
                    }

                    if (selected != "blue" && selected != "none" && selected != "orange")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                }


                if (hit.collider.gameObject.name == "Blue")
                {
                    if (bo == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "blue";
                            Debug.Log(selected);
                        }

                        if (selected == "orange")
                        {
                            bo = "connected";
                            selected = "none";
                            GameObject bwire = BO as GameObject;
                            bwire.transform.position = new Vector3 (-2.59f,0.84f,0);
                        }
                    }

                    if (selected != "blue" && selected != "none" && selected != "orange")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                }
                
                if (hit.collider.gameObject.name == "Red")
                {
                    if (rg == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "red";
                            Debug.Log(selected);
                        }

                        if (selected == "green")
                        {
                            rg = "connected";
                            selected = "none";
                            GameObject rwire = RG as GameObject;
                            rwire.transform.position = new Vector3 (-2.59f,0,0);
                        }
                    }

                    if (selected != "red" && selected != "none" && selected != "green")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                }


                if (hit.collider.gameObject.name == "Green")
                {
                    if (rg == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "green";
                            Debug.Log(selected);
                        }

                        if (selected == "red")
                        {
                            rg = "connected";
                            selected = "none";
                            GameObject rwire = RG as GameObject;
                            rwire.transform.position = new Vector3 (-2.59f,0,0);
                        }
                    }

                    if (selected != "red" && selected != "none" && selected != "green")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                    
                }
                
                if (hit.collider.gameObject.name == "Yellow")
                {
                    if (yp == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "yellow";
                            Debug.Log(selected);
                        }

                        if (selected == "purple")
                        {
                            yp = "connected";
                            selected = "none";
                            GameObject ywire = YP as GameObject;
                            ywire.transform.position = new Vector3 (-2.59f,-0.42f,0);
                        }
                    }

                    if (selected != "yellow" && selected != "none" && selected != "purple")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                    
                }

                if (hit.collider.gameObject.name == "Purple")
                {
                    if (yp == "disconnected")
                    {
                        if (selected == "none")
                        {
                            selected = "purple";
                            Debug.Log(selected);
                        }

                        if (selected == "yellow")
                        {
                            yp = "connected";
                            selected = "none";
                            GameObject ywire = YP as GameObject;
                            ywire.transform.position = new Vector3 (-2.59f,-0.42f,0);
                        }
                    }

                    if (selected != "yellow" && selected != "none" && selected != "purple")
                    {
                        Debug.Log("reset");
                        selected = "none";
                        rg = "disconnected";
                        bo = "disconnected";
                        yp = "disconnected";
                        GameObject rwire = RG as GameObject;
                        GameObject bwire = BO as GameObject;
                        GameObject ywire = YP as GameObject;
                        rwire.transform.position = new Vector3 (100,0,0);
                        bwire.transform.position = new Vector3 (100,0,0);
                        ywire.transform.position = new Vector3 (100,0,0);
                    }
                    
                }

                if (Begining.puzzlenumber == 1 && rg == "connected" && bo == "connected" && yp == "connected")
                {
                    transform.position = new Vector3 (100,0,0);
                }
            }
        }    
    }
}
