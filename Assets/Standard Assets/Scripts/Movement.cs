using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float y_speed = .5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		transform.Translate( new Vector3( 0, y_speed, 0));
	}

	public void setSpeed (float speed) {
		y_speed = speed;
	}
}
