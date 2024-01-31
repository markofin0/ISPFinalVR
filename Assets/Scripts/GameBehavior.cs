using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    private static GameBehavior _instance;

    public static GameBehavior Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameBehavior>();
                if (_instance == null)
                {
                    GameObject singleton = new GameObject("GameManagerSingleton");
                    _instance = singleton.AddComponent<GameBehavior>();
                    DontDestroyOnLoad(singleton); // Ensure the GameObject persists across scenes
                }
            }
            return _instance;
        }
    }

    public int basePoints = 1000; // Base points
    public int score = 1000;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to decrement points
    public void DecrementPoints(int amount)
    {
        score -= amount;
        if (score < 0)
        {
            score = 0; // Ensure score doesn't go negative
        }
    }
}
