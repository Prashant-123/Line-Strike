using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionThings : MonoBehaviour {

	public GameObject canvas;


	public static int score = 0;
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "Trigger") {	
			Destroy (GameObject.FindGameObjectWithTag ("Line"));
			score++;
		}
		else
		{
			Time.timeScale = 0;
			GameObject.Find ("SwipeManager").SetActive(false);
			GameObject.Find ("GameManager").SetActive(false);
			Destroy (GameObject.FindGameObjectWithTag ("Line"), 0);
			canvas.SetActive (true);

		}	
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}

	}
}
