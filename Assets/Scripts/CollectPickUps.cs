using UnityEngine;
using System.Collections;

public class CollectPickUps : MonoBehaviour {

    ScoreScript Score;
    void Awake()
    {
       Score = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "drumstick")
        {
            Destroy(col.gameObject);
            Score.Score++;
        }
    }
}
