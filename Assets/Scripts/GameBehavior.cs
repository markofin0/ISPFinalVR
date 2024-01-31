using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public string labelText = "Avoid the vehicles!!!";
    public bool showWinScreen = false;
    public int points = 1000;

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Points: " + points);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }
    }

    // Decrease points when player collides with a car
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Van"))
        {
            DecrementPoints(100);
        }

        if (collision.gameObject.CompareTag("EndOfLevel"))
        {
            LoadNextLevel();
        }
    }

    // Method to decrement points
    public void DecrementPoints(int amount)
    {
        points -= amount;
        if (points <= 0)
        {
            labelText = "Game Over! You Lost!";
            Time.timeScale = 0.0f; // Pause the game
        }
    }

    // Method to load the next level
    void LoadNextLevel()
    {
        // Assuming the next level is at build index 1, you can change it to the appropriate index
        SceneManager.LoadScene(1);
    }
}