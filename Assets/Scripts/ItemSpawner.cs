using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{

    public GameObject spawnObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(spawnObject, transform.position, transform.rotation);
        }

    }
}
