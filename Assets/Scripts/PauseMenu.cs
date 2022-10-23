using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;
    [SerializeField] GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            //Application.LoadLevel("SceneName");
            SceneManager.LoadScene("QuitScene");
            GamePause = true;
            
        }
        
    }
}
