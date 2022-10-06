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
    public TMP_Text newRecordImg;
    private bool isNewRecord=false;
    private saveLoad saveLoadScript;
    
    [Space]
    [Header("Sounds")]
    public AudioClip newRecordAudio;
    private audioManager audioMan;

    void Start()
    {
        
        saveLoadScript = FindObjectOfType<saveLoad>();
        record= saveLoadScript.Load();
        recordImg.text = record.ToString();
        audioMan = FindObjectOfType<audioManager>();
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
            audioMan.setAudio(newRecordAudio);
            audioMan.PlaySource();
            newRecordImg.enabled = true;
        }
    }
}
