using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    private Text scoreText;

    private void Start()
    {
        // Find the Text component
        scoreText = GetComponent<Text>();

        // Update the text initially
        UpdateScoreText();
    }

    private void Update()
    {
        // Update the text every frame
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        // Get the current score from the GameManager
        int currentScore = GameBehavior.Instance.score;

        // Update the text to display the current score
        scoreText.text = "Score: " + currentScore.ToString();
    }
}
