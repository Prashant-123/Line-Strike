using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateThings : MonoBehaviour {

	public GameObject line;
	private Vector3 spawnPosition;
	private float[] xPos = { -2, 0, 2 };
	private int p;
	public GameObject canvas;
	public GameObject ad;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		canvas.SetActive (false);
		ad.GetComponent<ShowAd> ().enabled = false;
		InvokeRepeating ("inst", 2, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void inst()
	{

		int x = Random.Range (0, 2);
		if (p == x) {
			if (x == 2)
				x = Random.Range (0, 1);
			else
				x++;
		}
		spawnPosition = new Vector3 (xPos [x], 8, 0);
		Instantiate (line, spawnPosition, Quaternion.identity);

		
		//yield return new WaitForSeconds (2);
		p = x;

	}
}
