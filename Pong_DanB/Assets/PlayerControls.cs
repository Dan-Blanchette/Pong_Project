using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.I;
    public KeyCode moveDown = KeyCode.K;
    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("escape"))
       {
          Application.Quit();
          Debug.Log("Quitting Game.");
       }
       var velocity = rb2d.velocity;
       
       if (Input.GetKey(moveUp)) 
       {
           velocity.y = speed;
       }
       else if (Input.GetKey(moveDown)) 
       {
           velocity.y = -speed;
       }
       else 
       {
           velocity.y = 0;
       }

       rb2d.velocity = velocity;

       var position = transform.position;
       if (position.y > boundY) 
       {
           position.y = boundY;
       }
       else if (position.y < -boundY) 
       {
           position.y = -boundY;
       }

       transform.position = position;
    }
}
