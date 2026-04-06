using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Settings")]
    [SerializeField] private int scoreToWin = 11;

    [Header("References")]
    [SerializeField] private Ball ball;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI computerScoreText;

    private int _playerScore;
    private int _computerScore;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void OnPlayerScore()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        CheckWinCondition();
    }

    public void OnComputerScore()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (_playerScore >= scoreToWin) {
            Debug.Log("Player Menang!");
            EndGame();
        } 
        else if (_computerScore >= scoreToWin) {
            Debug.Log("Computer Menang!");
            EndGame();
        } 
        else {
            ball.ResetBall();
        }
    }

    private void EndGame()
    {
        // Untuk sekarang kita restart aja gamenya kalau ada yang menang
        // Nanti bisa kamu tambah UI "Game Over" di sini
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}