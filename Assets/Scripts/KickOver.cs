using UnityEngine;
using System.Collections;

public class KickOver : MonoBehaviour
{

    bool Jump = false;
    MovingObject mScript;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D Coll)
    {

        if (Coll.gameObject.tag == "Spring")
        {
           //  Destroy(Coll.gameObject);
            Coll.gameObject.rigidbody2D.isKinematic = true;
            Component[] Colliders = Coll.gameObject.GetComponents<BoxCollider2D>();
            foreach (BoxCollider2D b in Colliders)
            {
                b.isTrigger = true;
                
            }
            Coll.gameObject.GetComponent<MovingObject>().enabled = true;
            Debug.Log("jump is true");
            Jump = true;
        }

    }

    void FixedUpdate()
    {
        if (Jump)
        {           
            rigidbody2D.AddForce(new Vector2(0, 250));
            Jump = false;
        }
    }
}
