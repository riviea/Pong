using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager_BlockBreak: MonoBehaviour
{
    [Header("Ball")]
    public BallController ball;

    [Header("Player 1")]
    public PlayerController player1Paddle;
    public Goal player1Goal;

    [Header("UI")]
    private int score = 0;
    public TextMeshProUGUI scoreText;

    public void Player1Scored()
    {
        score++;
        scoreText.text = scoreText.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.Reset();   
    }
}
