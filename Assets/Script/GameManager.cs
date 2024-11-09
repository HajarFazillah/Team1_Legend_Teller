using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static float moveSpeed = 2f;

    private int score = 0;  // Player's score (total points)
    private int coinCount = 0;  // Number of coins collected
    public TMP_Text scoreText;  // UI Text element to display the score
    public TMP_Text coinCountText;  // UI Text element to display the coin count

    private void Awake()
    {
        // Setup singleton instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateScoreText();
        UpdateItemCountText();  // Update the coin counter UI
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    public void AddCoin()  // New method to update coin count
    {
        coinCount++;
        UpdateItemCountText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void UpdateItemCountText()  // Update coin count UI
    {
        if (coinCountText != null)
            coinCountText.text = "Coins: " + coinCount;
    }

    public void GameStart()
    {
        
    }

    public void GameStop()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void DecreasePlayerHealth()
    {

    }
}
