using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLine : MonoBehaviour {
	
	//float speed = -0.1f;
	Vector3 pos;
	float sapeed;
	// Use this for initialization
	void Start () {

		sapeed = SapeedControl.speed;
		pos = new Vector3 (0, sapeed, 0);
		//Debug.Log (pos);
	}
	
	// Update is called once per frame
	void Update () {
	//	sapeed -= 0.001f;
		gameObject.transform.transform.position = gameObject.transform.position + pos;

	}


}
