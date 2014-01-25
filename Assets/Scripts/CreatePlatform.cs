using UnityEngine;
using System.Collections;

public class CreatePlatform : MonoBehaviour
{
    public GameObject[] Obstacles = new GameObject[3];

    // Use this for initialization
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("hello");
        if (coll.gameObject.tag == "EndBarrier")
        {
            DestroyObject(this.gameObject);
        }
    }
}
