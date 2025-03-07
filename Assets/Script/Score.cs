using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public int score;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore();
    }


    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
