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
    private Animator gameOverAnimator;

    [Space]
    [Header("Sounds")]
    public AudioClip gameOverAudio;
    private audioManager audioMan;
    void Start()
    {
        scoreManage = FindObjectOfType<ScoreManager>();
        audioMan = FindObjectOfType<audioManager>();
        gameOverAnimator = gameOverScreen.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.tag == "Player")
        {
            audioMan.setAudio(gameOverAudio);
            audioMan.PlaySource();
            Invoke("showGameOverScreen", 2f);
        }
    }

    private void showGameOverScreen()
    {
        isGameOver = true;
        gameOverScreen.enabled = true;
        gameOverAnimator.enabled = true;
        scoreManage.ScoreManage();
    }
}
