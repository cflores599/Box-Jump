using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
 
    public bool onGround = true;
    public Rigidbody2D rb2d;
    public bool clicked = false;
   

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
      
    }
    private void Update()
    {    

    }
    public void Jump(float jumpForce)
    {
        rb2d.velocity = new Vector2(0, 1) * jumpForce;

    }


    public void OnCollisionEnter2D(Collision2D col)
    {
      
        if (col.gameObject.tag == "stand")
        {
            onGround = true;
            Debug.Log("enter");
        }
    }

  

    public void OnCollisionExit2D(Collision2D col)
    {
      
        if (col.gameObject.tag == "stand")
        {
            onGround = false;
            Debug.Log("exit");
        }
    }
}
