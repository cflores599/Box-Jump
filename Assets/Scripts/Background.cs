using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {


    public float speed;
    public float Xend;
    public float Xstart;
    private Player player;

    public void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (!player.onGround)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x < Xend)
            {
                Vector2 pos = new Vector2(Xstart, transform.position.y);
                transform.position = pos;
            }
        }
        
    }
}
