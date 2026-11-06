using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    void Start()
    {
        UpdateScore();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

}
