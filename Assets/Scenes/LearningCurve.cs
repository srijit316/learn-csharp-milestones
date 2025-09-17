using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Explicit access modifiers
    public int playerAge = 21;
    private float playerHeight = 5.9f;
    public string playerName = "Srijit";
    private bool isGameOver = false;

    void Start()
    {
        // Logging variables
        Debug.Log("Player Name: " + playerName);  // string concatenation
        Debug.LogFormat("Age: {0}, Height: {1}", playerAge, playerHeight); // Debug.LogFormat
        Debug.Log($"Is Game Over? {isGameOver}"); // string interpolation

        // Using a method with parameters
        int pointsEarned = CalculatePoints(5, 10);
        Debug.Log($"Points Earned: {pointsEarned}");

        // Using return value from a method
        string stats = GetPlayerStats(playerName, playerAge);
        Debug.Log(stats);
    }

    void Update()
    {
        // Update logic can be added here
    }

    // Simple method with parameters & return type
    private int CalculatePoints(int questsCompleted, int classesAttended)
    {
        int totalPoints = (questsCompleted * 100) + (classesAttended * 50);
        return totalPoints;
    }

    // Second method returning a string
    private string GetPlayerStats(string name, int age)
    {
        return $"Player {name} is {age} years old.";
    }
}
