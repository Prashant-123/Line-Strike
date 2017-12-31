using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapeedControl : MonoBehaviour {

	public static float speed;
	// Use this for initialization
	void Start () {
		speed = -0.1f;
		InvokeRepeating ("s", 5, 4);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void s()
	{
		speed -= 0.002f;	
	}
}
