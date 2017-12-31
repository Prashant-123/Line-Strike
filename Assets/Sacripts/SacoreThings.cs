using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SacoreThings : MonoBehaviour {

	private int sacore;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		sacore = CollisionThings.score;
		scoreText.text = sacore.ToString ();
	}
}
