using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    public int startingPoints = 1000;
    private int currentPoints;

    public Text pointsText;

    void Start()
    {
        currentPoints = startingPoints;
        UpdatePointsDisplay();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Van"))
        {
            currentPoints -= 100;
            UpdatePointsDisplay();
        }
    }

    void UpdatePointsDisplay()
    {
        pointsText.text = "Points: " + currentPoints.ToString();
    }
}