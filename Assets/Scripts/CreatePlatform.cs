using UnityEngine;
using System.Collections;

public class CreatePlatform : MonoBehaviour
{
    public GameObject[] Obstacles = new GameObject[3];

    // Use this for initialization
    void Awake()
    {
<<<<<<< HEAD

        float x = Random.Range(0.5f, 3);
        this.transform.localScale = new Vector3(x, 1, 0);
        Instantiate(Obstacles[Random.Range(0, 3)], new Vector2(10, -4), transform.rotation);

=======
>>>>>>> 2b5bc8ae47625a60037201d86c12ee3fa770d4e6
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
