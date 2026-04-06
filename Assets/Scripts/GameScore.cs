using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public bool isComputerScoreZone; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isComputerScoreZone) {
                GameManager.Instance.OnComputerScore();
            } else {
                GameManager.Instance.OnPlayerScore();
            }
        }
    }
}