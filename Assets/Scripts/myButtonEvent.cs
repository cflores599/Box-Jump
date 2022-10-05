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
    public Image forceBar;
    
    void Start()
    {
        maxJumpforce = 1;
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicking)
        {
            if(maxJumpforce > 0)
            {
                jumpForce += Time.deltaTime * 7;
                forceBar.fillAmount=jumpForce;
                maxJumpforce -= Time.deltaTime;
            }
          
        
            
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    { 
        base.OnPointerDown(eventData);
        clicking = true;
        Debug.Log("Pressed");
      
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        clicking = false;
        player.Jump(jumpForce);
        jumpForce = 3;
        maxJumpforce = 1;
    }
}
