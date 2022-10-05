using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentScore=-1;
    private float record=0;
    public TMP_Text scoreImg;
    public TMP_Text recordImg;
    private bool isNewRecord=false;
    private saveLoad saveLoadScript;

    void Start()
    {
        
        saveLoadScript = FindObjectOfType<saveLoad>();
        record= saveLoadScript.Load();
        recordImg.text = record.ToString();
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
            isNewRecord = true;
            record = currentScore;
            recordImg.text = record.ToString();
        }
        scoreImg.text = currentScore.ToString();

    }
    public void ScoreManage()
    {
        if (isNewRecord)
        {
            saveLoadScript.Save(record);
        }
    }
}
