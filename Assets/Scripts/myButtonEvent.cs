using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class myButtonEvent : Button
{
    // Start is called before the first frame update
    private Player player;
    public float jumpForce = 3;
    private bool clicking = false;
    private float maxJumpforce = 1;
    public Image img;
    private spawn spaw;
    private float barForceController;
    public AudioClip charge;
    
    private audioManager audioMan;

    void Start()
    {
        maxJumpforce = 1;
        player = FindObjectOfType<Player>();
        img = GameObject.FindGameObjectWithTag("forceBar").GetComponent<Image>();
        spaw = FindObjectOfType<spawn>();
        audioMan = FindObjectOfType<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {


        if (clicking)
        {
            if(maxJumpforce > 0)
            {
              
                jumpForce += Time.deltaTime * 7;
                maxJumpforce -= Time.deltaTime;
                if(barForceController < 1)
                {
                    barForceController += Time.deltaTime;
                }
               
            }
            img.fillAmount = barForceController;

           
        }

        
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (player.getOnGround())
        {
            base.OnPointerDown(eventData);
            clicking = true;
            Debug.Log("Pressed");
        //    audioMan.setAudio(charge);
            //audioMan.PlaySource();
        }
    
      
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (player.getOnGround())
        {
            base.OnPointerUp(eventData);
            clicking = false;
            player.Jump(jumpForce);
            spaw.Instantiate();
            jumpForce = 3;
            maxJumpforce = 1;
            barForceController = 0;
            img.fillAmount = barForceController;
        }
      //  audioMan.StopSource();
    }
}
