using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{

    public GameObject[] spawnObjects;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {          
            Instantiate(spawnObjects[Random.Range(0, 2)], transform.position, transform.rotation);
        }

    }
}
