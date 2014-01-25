using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject spawnObject;
    public Vector2 yRange;
    public float SpawnRate;

    private Vector2 spawnPosition;

    void Start()
    {
        InvokeRepeating("Spawn", 0, SpawnRate);
    }

    void Spawn()
    {
        float i = Random.Range(yRange.x, yRange.y);
        spawnPosition = new Vector2(10, i);
        Instantiate(spawnObject, transform.position, transform.rotation);
    }
}