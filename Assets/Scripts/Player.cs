using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    private bool onGround = true;
    private Rigidbody2D rb2d;
    private ScoreManager scoreManager;
    private Animator anim;
    public GameObject jumpEffect;
    public Animator camAnim;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {    

    }
    public void Jump(float jumpForce)
    {
        rb2d.velocity = new Vector2(0, 1) * jumpForce;
        anim.SetTrigger("jump");
     //   camAnim.SetTrigger("shake");
        Instantiate(jumpEffect, transform.position, Quaternion.identity);


    }


    public void OnCollisionEnter2D(Collision2D col)
    {
      
        if (col.gameObject.tag == "stand")
        {
            if(col.gameObject.transform.position.y < transform.position.y - 1)
            {
                onGround = true;
                scoreManager.addScore();
                anim.SetTrigger("stand");
            }
         
  
        }
    }

  

    public void OnCollisionExit2D(Collision2D col)
    {
      
        if (col.gameObject.tag == "stand")
        {
            onGround = false;
         
        }
    }

    public bool getOnGround()
    {
        return onGround;
    }
}
