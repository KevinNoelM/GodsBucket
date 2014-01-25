using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    public int Score = 0;
	
	// Update is called once per frame
	void Update () {
        guiText.text= "Score: " + Score;
	}
}
