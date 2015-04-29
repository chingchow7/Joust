using UnityEngine;
using System.Collections;
using SmoothMoves;

public class AttackScript : MonoBehaviour {

	private BoneAnimation 	 boneAnimation;
	private Animation		 animation;

	// Use this for initialization
	void Awake () {
		boneAnimation = GetComponent<BoneAnimation>();
		animation = boneAnimation.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			boneAnimation.Play ("Attack");
		}
		//Debug.Log ("frame # is " + boneAnimation["Attack"].frame);
	}
}
