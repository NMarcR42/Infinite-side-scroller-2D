using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlateform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Contains("plateform") )
        {
            // The player is grounded
            Destroy(collision.gameObject);        
        }        
        
        
    }
}
