using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreThings : MonoBehaviour {

	public Text high;
	public static int highScore;
	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt ("highscore");
	}
	
	// Update is called once per frame
	void Update () {
		high.text = highScore.ToString ();
		if (CollisionThings.score > highScore) {
			highScore = CollisionThings.score;
			PlayerPrefs.SetInt ("highscore", highScore); 
		}
	}
}
