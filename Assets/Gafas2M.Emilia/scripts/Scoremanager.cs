using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text resultText;

    [Header("Game Rules")]
    [SerializeField] private int targetScore = 100;

    private int currentScore = 0;
    private bool gameFinished = false;

    private void Start()
    {
        UpdateUI();
        if (resultText != null)
        {
            resultText.text = "";
        }
    }

    public void AddPoints(int points)
    {
        if (gameFinished) return;

        currentScore += points;
        UpdateUI();

        if (currentScore >= targetScore)
        {
            FinishGame();
        }
    }

    public void ResetScore()
    {
        currentScore = 0;
        gameFinished = false;
        UpdateUI();

        if (resultText != null)
        {
            resultText.text = "";
        }
    }

    private void FinishGame()
    {
        gameFinished = true;

        if (resultText != null)
        {
            resultText.text = "¡Nivel completado!";
        }
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntos: " + currentScore + " / " + targetScore;
        }
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}