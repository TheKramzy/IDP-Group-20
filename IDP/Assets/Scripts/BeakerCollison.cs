using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakerCollison : MonoBehaviour
{
    public GameObject puzzle5;
    public GameObject cipher;
    public GameObject paper;
    public GameObject background;
    public GameObject rose;
    public GameObject cheese;
    public GameObject tysolin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Begining.puzzlenumber == 5)
        {
            cipher.transform.position = new Vector3 (-1,0,0);
            paper.transform.position = new Vector3 (5,0,0);
            background.transform.position = new Vector3 (-6.6f,0,0);
            rose.transform.position = new Vector3(-7,2,0);
            cheese.transform.position = new Vector3(-7,-0.5f,0);
            tysolin.transform.position = new Vector3(-7,-3,0);
        }
    }

    private  void Update()
    {
        if (Begining.puzzlenumber == 5)
        {
            if (Puzzle5Failsafe.list == 3)
            {
                Begining.cutscene = true;
                Begining.puzzlenumber = 6;
                puzzle5.transform.position = new Vector3(100,0,0);
                rose.transform.position = new Vector3(-1000,2,0);
                cheese.transform.position = new Vector3(-7000,-0.5f,0);
                tysolin.transform.position = new Vector3(-7000,-3,0);
            }
        }
    }
}
