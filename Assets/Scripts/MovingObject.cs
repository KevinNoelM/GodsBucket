using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

    public Vector2 speed;
    public float destroyTime;

    private Vector2 movement;
    private BoxCollider2D boxCollider;

   
    void Update()
    {
        movement = new Vector2(speed.x, speed.y);
        Destroy(gameObject, destroyTime);
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}