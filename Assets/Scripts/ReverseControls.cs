using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseControls : MonoBehaviour
{

    [Header("Player 1")]
    public GameObject player1Paddle;

    [Header("Player 2")]
    public GameObject player2Paddle;

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
        Ball ball = other.GetComponent<Ball>();
        GameObject player1 = GameObject.Find("Player1");
        if(ball.rb.velocity.x > 0) {
            player2Paddle.GetComponent<Paddle>().reversePlayer2 = true;
            player2Paddle.GetComponent<Paddle>().TriggerNormalControls();
        } else {
            player1Paddle.GetComponent<Paddle>().reversePlayer1 = true;
            player1Paddle.GetComponent<Paddle>().TriggerNormalControls();
        }
    }
}
