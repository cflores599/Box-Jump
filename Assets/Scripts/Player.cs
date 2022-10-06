using System;
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

    [Space]
    [Header("Sounds")]
    public AudioClip jumpAudio;
    private audioManager audioMan;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        anim = GetComponent<Animator>();
        audioMan = FindObjectOfType<audioManager>();
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
        audioMan.setAudio(jumpAudio);
        audioMan.PlaySource();

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
