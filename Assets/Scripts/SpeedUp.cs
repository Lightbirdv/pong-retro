using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float amount;

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
        Ball ball = other.GetComponent<Ball>();
        Vector2 v = new Vector2(amount,amount);
        ball.rb.velocity = v * ball.rb.velocity;
    }
}
