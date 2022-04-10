using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    private GameObject[] powerups;

    public void Player1Scored() {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored() {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition() {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();

    }

    void Start() {
        powerups = GameObject.FindGameObjectsWithTag("Power up");
        InvokeRepeating("SpawnPowerUp", 5.0f, 15.0f);
    }

    void SpawnPowerUp() {
        GameObject randomObject = powerups[Random.Range(0,powerups.Length)].gameObject;
        Instantiate(randomObject, new Vector3(0, Random.Range(-4, 4), 0),randomObject.transform.rotation);
    }
}
