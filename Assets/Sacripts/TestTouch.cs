using UnityEngine;
using System.Collections;


public class TestTouch : MonoBehaviour {

	public float smooth = 100;
	public float speed = 0.5f;

	// Use this for initialization

	void Start () {
		gameObject.GetComponent<TrailRenderer> ().startWidth = 0.1f;
		gameObject.GetComponent<TrailRenderer> ().endWidth = 0.02f;
	}
	// Update is called once per frame

	void FixedUpdate () {
		if (Input.touchCount > 0) {
			// The screen has been touched so store the touch
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Moved) {
				Vector2 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y,10));
				transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime * smooth );
			}
		}
	}
}