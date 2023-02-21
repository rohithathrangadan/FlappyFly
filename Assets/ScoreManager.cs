using System;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int score;
    public TextMeshProUGUI _scoreDisplay;
  
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        DisplayScore();
    }

    // Update is called once per frame
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PipeScore")
        {
            score++;
            Debug.Log(score);
            DisplayScore();
        }
    }

    private void DisplayScore()
    {
        _scoreDisplay.text = score.ToString();
    }

    public void ResetScoreOnRestart()
    {
        score = 0;
        DisplayScore();
    }
}
