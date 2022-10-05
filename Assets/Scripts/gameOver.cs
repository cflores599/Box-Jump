using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas gameOverScreen;
    private bool isGameOver=false;
    private ScoreManager scoreManage;

    void Start()
    {
        scoreManage = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.tag == "Player")
        {
            isGameOver=true;
            gameOverScreen.enabled = true;
            scoreManage.ScoreManage();
        }
    }
}
