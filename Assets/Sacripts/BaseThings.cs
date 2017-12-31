using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseThings : MonoBehaviour {

	public GameObject canvas;

	void OnTriggerEnter(Collider other)
	{
			if (other.gameObject.CompareTag ("Line")) {
			Time.timeScale = 0;
			Destroy (GameObject.FindGameObjectWithTag ("Line"), 0);
			canvas.SetActive (true);
			}
	}
}
