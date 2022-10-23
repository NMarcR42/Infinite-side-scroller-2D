using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Kill object
        Destroy(collision.gameObject);
        
        //Restart
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
   
}
