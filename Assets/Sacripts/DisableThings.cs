﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableThings : MonoBehaviour {

	public GameObject trail;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0))
			trail.SetActive (true);
		else
			trail.SetActive (false);

		if (Time.timeScale == 0)
			trail.SetActive (false);
	}
}
