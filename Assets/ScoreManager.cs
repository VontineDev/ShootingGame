using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    public int bestScore;
    public Text txtScore;
    public Text txtBestScore;

    // Start is called before the first frame update
    void Start()
    {

    }
    public int GetScore()
    {
        return currentScore;
    }
    public void SetScore(int value)
    {
        currentScore = value++;

        txtScore.text = $"Score: {currentScore}";
        if (currentScore > bestScore)
        {
            txtBestScore.text = $"BestScore: {bestScore}";
        }
    }
}
