using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyUp(KeyCode.M)){
    //         LoadScene();
    //     }
        
    // }
    // void LoadScene(){
    //     SceneManager.LoadScene(0);
    // }
    public void QuitGame(){
        Application.Quit();
        Debug.Log("Vous pouvez fuir autant que vous le pouvez ... Mais je vous retrouverai!");
    }

    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        Debug.Log("Welcome to the hell");
    }

}
