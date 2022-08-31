using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        // provide a 2 second time delay before ball starts to move
        Invoke("mvBall", 2);
    }

    // chooses a random directon for the ball to move in
    void mvBall()
    {
        float rand = Random.Range(0,2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }
    
    // Reset the Ball position to starting coordinates
    void BallReset()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // RestartGame after a 1 second delay
    void RestartGame()
    {
        BallReset();
        Invoke("mvBall", 1);
    }

    // detects collisions between ball and paddle object maintains speed
    void Is_Collision_2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + 
            (collision.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }
}