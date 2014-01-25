using UnityEngine;
using System.Collections;

public class CreatePlatform : MonoBehaviour
{
    public GameObject[] Obstacles = new GameObject[3];

    // Use this for initialization
    void Awake()
    {

        float x = Random.Range(0.5f, 3);
        this.transform.localScale = new Vector3(x, 1, 0);
        Instantiate(Obstacles[Random.Range(0, 2)], new Vector2(10, -4), transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
