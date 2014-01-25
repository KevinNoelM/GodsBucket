using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

    public Vector2 speed;

    private Vector2 movement;
    private BoxCollider2D boxCollider;

   
    void Update()
    {
        movement = new Vector2(speed.x, speed.y);
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}