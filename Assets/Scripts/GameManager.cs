using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Stats")]
    public int health = 3;
    public int projectilesFired = 0;
    public int winProjectileCount = 10;

    [Header("UI References")]
    public TMP_Text healthText;
    public TMP_Text projectileText;
    public TMP_Text winText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateUI();
        winText.gameObject.SetActive(false);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            GameOver();
        }
        UpdateUI();
    }

    public void AddProjectileFired()
    {
        projectilesFired++;
        UpdateUI();

        if (projectilesFired >= winProjectileCount)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        winText.gameObject.SetActive(true);
        winText.text = " You Win! Congrats! 10 shots fired";
        Time.timeScale = 0; // Pause game
    }

    void GameOver()
    {
        winText.gameObject.SetActive(true);
        winText.text = "💀 Game Over";
        Time.timeScale = 0;
    }

    void UpdateUI()
    {
        healthText.text = $" Health: {health}";
        projectileText.text = $" Shots: {projectilesFired}/{winProjectileCount}";
    }
}
