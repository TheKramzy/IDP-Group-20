using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour{

    public static void ToSurvey(){
        SceneManager.LoadScene(1);
    }

     public static void ToGame(){
        SceneManager.LoadScene(0);
    }

}
