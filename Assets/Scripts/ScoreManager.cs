using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score;
    public TextMeshProUGUI _scoreDisplay;
    public TextMeshProUGUI _endScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        DisplayScore();
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PipeScore")
        {
            score++;
            Debug.Log(score);
            DisplayScore();
        }
    }

    private void DisplayScore()
    {
        _endScore.text = _scoreDisplay.text = score.ToString();
    }

    //since scene loads each time on restart..the score is reset in the start function
    //public void ResetScoreOnRestart()
    //{
    //    score = 0;
    //    DisplayScore();
    //}
}
