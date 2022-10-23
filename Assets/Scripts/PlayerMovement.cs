using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float jump;
    public Rigidbody2D playerRB;
    public bool isGrounded;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject){
            // The player is grounded
            isGrounded = true;
        }
    }


    private void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRB.AddForce(Vector3.up * jump, ForceMode2D.Impulse);
            isGrounded = false;
        }

    }
}
