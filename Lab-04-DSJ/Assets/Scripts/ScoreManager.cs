using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void AddPoint()
    {
        score += 1;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Puntos: " + score.ToString();
    }
}
