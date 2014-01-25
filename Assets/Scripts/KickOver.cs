using UnityEngine;
using System.Collections;

public class KickOver : MonoBehaviour
{

    bool Jump = false;
    MovingObject mScript;
    private Animator anim;
    FireScript Fire;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
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
            Jump = true;
        }

        else if (Coll.gameObject.tag == "Fire") {
            Fire = Coll.gameObject.GetComponent<FireScript>();
            if (Fire != null && Fire.Burning)
            {
                Debug.Log("Burn");
            }
            else if (!Fire.Burning)
            {
                Debug.Log("No Burn");
            }
        }

        else if (Coll.gameObject.tag == "Water")
        {
            Debug.Log("Drowned MotherFucker");
        }
        else if (Coll.gameObject.tag == "Duck")
        {
            Debug.Log("Decapitated MotherFucker");
        }
        else if (Coll.gameObject.tag == "Bucket")
        {
            
            if (Physics2D.Linecast(transform.position, new Vector2(transform.position.x + 3, transform.position.y), 1 << LayerMask.NameToLayer("Fire")))
            {                          
                GameObject[] g = GameObject.FindGameObjectsWithTag("Fire");
                foreach (GameObject GO in g) 
                {
                     if (GO.transform.position.x - Coll.transform.position.x < 5)
                     { 
                        Fire = GO.GetComponent<FireScript>();
                        Fire.Burning = false;
                        Debug.Log("Watered that bitch");
                     }
                }
            }
            
            Destroy(Coll.gameObject);
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
