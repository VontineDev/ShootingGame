using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public Action scoreAddFunc;
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreAddFunc += ShowScore;
    }
    public void AddScore()
    {
        score++;
        scoreAddFunc();
    }
    void ShowScore()
    {
        scoreText.text = score.ToString();
    }
}
