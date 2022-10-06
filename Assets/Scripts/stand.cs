using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stand : MonoBehaviour
{
    public float speed;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.getOnGround())
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }
    }
}
