using UnityEngine;
using System.Collections;

public class PlatformSpawner : MonoBehaviour {

    public GameObject[] platforms;
    public float SpawnRate;
    public float gapDistance;

    private Vector2 spawnPosition;

    void Start()
    {
        InvokeRepeating("Spawn", 0, SpawnRate);
    }

    void Spawn()
    {
        float distance = float.MaxValue;
        GameObject closestPlatform = null;
        GameObject[] _platforms = GameObject.FindGameObjectsWithTag("Platform");
        GameObject endBarrier = GameObject.FindGameObjectWithTag("EndBarrier");
        if (_platforms.Length < 6)
        {
            foreach (GameObject p in _platforms)
            {
                float num = Mathf.Abs(p.transform.position.x - endBarrier.transform.position.x);
                if (num < distance)
                {
                    closestPlatform = p;
                }
            }

            int index = Random.Range(0, 2);
            float xPos = closestPlatform.transform.position.x + closestPlatform.GetComponent<BoxCollider2D>().size.x / 2 + gapDistance + platforms[index].GetComponent<BoxCollider2D>().size.x/2;
           // Debug.Log("closest platform position " + closestPlatform.transform.position.x + " : " + xPos);
            Vector2 pos = new Vector2(xPos, transform.position.y);
            
            Instantiate(platforms[index], pos, transform.rotation);
        }
    }
}

