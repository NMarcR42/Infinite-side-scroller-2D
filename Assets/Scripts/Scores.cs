using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    public Text MyText;
    private int points;
 
 
    // Use this for initialization
    void Start () {
   
        MyText.text = "Score : 0";
 
    }
 
 
    // Update is called once per frame
    void Update () {
   
        MyText.text = "Score : " + points;
 
    }
 
 
    void OnTriggerEnter2D(Collider2D addScore) {
        if(addScore.tag =="score"){
            points ++;
        }
 
    }
}
