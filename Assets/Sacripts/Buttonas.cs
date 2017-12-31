using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttonas : MonoBehaviour {

	public void restarat()
	{
		SceneManager.LoadScene (1);
		CollisionThings.score = 0;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void play()
	{
		SceneManager.LoadScene (1);
	}
}
