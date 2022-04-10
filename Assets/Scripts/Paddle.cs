using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;
    public bool reversePlayer1 = false;
    public bool reversePlayer2 = false;

    void Start() {
        startPosition = transform.position;   
    }

    void Update()
    {
        if (isPlayer1){
            if (reversePlayer1) {
                movement = -Input.GetAxisRaw("Vertical");
            } else {
                movement = Input.GetAxisRaw("Vertical");
            }
        } else {
            if (reversePlayer2) {
                movement = -Input.GetAxisRaw("Vertical2");
            } else {
                movement = Input.GetAxisRaw("Vertical2");
            }
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

    public void TriggerNormalControls() {
        StartCoroutine(Normalize(5));
    }

    private IEnumerator Normalize(float time) {
        yield return new WaitForSeconds(time);
        Debug.Log("Start normalizing");
        reversePlayer1 = false;
        reversePlayer2 = false;
    }
}
