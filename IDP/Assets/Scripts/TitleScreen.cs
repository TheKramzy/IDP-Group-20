using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    public GameObject Titlescreen;
    public GameObject OpeningCutscene;
    public GameObject dialogue;

    void Start()
    {
        dialogue.transform.position = new Vector3 (100,0,0);
        Begining.cutscene = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "PlayButton")
                {
                    Titlescreen.transform.position = new Vector3 (100,0,0);
                    OpeningCutscene.transform.position = new Vector3 (0,0,0);
                    Begining.cutscene = true;
                }
            }
        }
    }
}
