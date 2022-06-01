using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;



public class exportdata : MonoBehaviour
{

    [SerializeField] InputField Answer1;
    [SerializeField] InputField Answer2;
    [SerializeField] InputField Answer3;
    [SerializeField] InputField Answer4;
    [SerializeField] InputField Answer5;
    [SerializeField] InputField Answer6;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeyCdx9sXwznBHESlnf5UdFRCI8zhSBFzsmRvLwsF9qrjU_5A/formResponse";


    public void Send()
    {
        if (Answer1.text == "" || Answer2.text == "" || Answer3.text == "" || Answer4.text == "" || Answer5.text == "")
        {
            return;
        }
        StartCoroutine(Post(Answer1.text, Answer2.text, Answer3.text, Answer4.text, Answer5.text, Answer6.text));
    }

    IEnumerator Post(string s1, string s2, string s3, string s4, string s5, string s6)
    {


        WWWForm form = new WWWForm();
        form.AddField("entry.836595576", s1);
        form.AddField("entry.1023523404", s2);
        form.AddField("entry.1373053647", s3);
        form.AddField("entry.1086390998", s4);
        form.AddField("entry.794583168", s5);
        form.AddField("entry.1233911286", s6);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }

}
