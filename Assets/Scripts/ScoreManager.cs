using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentScore=-1;
    private float record;
    public TMP_Text scoreImg;
    public TMP_Text recordImg;


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
        if (record < currentScore)
        {
            record = currentScore;
            recordImg.text = record.ToString();
        }
        scoreImg.text = currentScore.ToString();

    }
}
