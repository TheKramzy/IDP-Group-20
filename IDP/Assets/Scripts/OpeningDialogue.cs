using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpeningDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI text;
    public GameObject Dialoguebox;
    public GameObject PlaninDrawer;
    public GameObject Opening;
    public GameObject Act1;
    public GameObject Act2;
    public GameObject Act3;
    public GameObject Player;


    void Start()
    {
        dialogue.index = 0;
        Debug.Log(dialogue);
    }
    // Start is called before the first frame update
    void Update()
    {
        if (Begining.cutscene == true)
        {
            Dialoguebox.transform.position = new Vector3 (0,-2,0);
            if (Input.GetMouseButtonUp(0))
            {
                NextLine();
            }
            if (dialogue.index == 0)
            {
                nameText.text = dialogue.charactername;
                text.text = dialogue.text[dialogue.index] + " (Click to continue!)";
            }
            if (dialogue.index == 3)
            {
                PlaninDrawer.transform.position = new Vector3 (5,-2,0);
            }
            if (dialogue.index == 6)
            {
                if (Input.GetMouseButtonUp(0))
                { 
                    Opening.transform.position = new Vector3 (100,0,0);
                    Act1.transform.position = new Vector3 (0,0,0);
                }
            }
            if (dialogue.index == 11)
            {
                ExitDialogue();
                if(Input.GetMouseButtonUp(0))
                {
                    Player.transform.position = new Vector3 (0,0,0);
                }
            }
            if (dialogue.index == 16)
            {
                ExitDialogue();
            }
            if (dialogue.index == 12)
            {
                ExitDialogue();
            }
        }

    }

    void NextLine()
    {

        dialogue.index += 1;
        text.text = dialogue.text[dialogue.index] + " (Click to continue!)";
    }
    void ExitDialogue()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Begining.cutscene = false;
            Dialoguebox.transform.position = new Vector3 (100,0,0);
        }
    }

}