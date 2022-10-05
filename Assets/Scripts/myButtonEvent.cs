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
    private spawner spaw;
    
    void Start()
    {
        maxJumpforce = 1;
        player = FindObjectOfType<Player>();
        img = GameObject.FindGameObjectWithTag("forceBar").GetComponent<Image>();
        spaw = FindObjectOfType<spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicking)
        {
            if(maxJumpforce > 0)
            {
              
                jumpForce += Time.deltaTime * 7;
                img.fillAmount = jumpForce;
                maxJumpforce -= Time.deltaTime;
              
            }
            
         
        
            
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (player.onGround)
        {
            base.OnPointerDown(eventData);
            clicking = true;
            Debug.Log("Pressed");
        }
    
      
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (player.onGround)
        {
            base.OnPointerUp(eventData);
            clicking = false;
            player.Jump(jumpForce);
            spaw.Instantiate();
            jumpForce = 3;
            maxJumpforce = 1;
        }
    }
}
