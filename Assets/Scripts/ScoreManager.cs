using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentScore=-1;
    public TMP_Text scoreImg;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        currentScore++;
        scoreImg.text = currentScore.ToString();
    }
}
