using UnityEngine;
using System.Collections;

public class FollowRigidBody : MonoBehaviour
{

    private Component[] rigidBodies;

    // Use this for initialization
    void Start()
    {
        rigidBodies = GetComponentsInChildren<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach(Rigidbody2D body in rigidBodies)
        {
            transform.position = body.transform.position;
        }
        

    }
}
