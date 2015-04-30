using UnityEngine;
using System.Collections;
using SmoothMoves;

public class AttackScript : MonoBehaviour {

	private BoneAnimation 	 boneAnimation;
	private Animation		 animation;
	private Movement	     movement;

	public string AttackInput;

	// Use this for initialization
	void Awake () {
		boneAnimation = GetComponent<BoneAnimation>();
		boneAnimation.RegisterColliderTriggerDelegate(WeaponHit);
		animation = boneAnimation.GetComponent<Animation>();
		movement = GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (AttackInput)) {
			boneAnimation.Play ("Attack");
		}
		//Debug.Log ("frame # is " + boneAnimation["Attack"].frame);
	}

	public void WeaponHit(ColliderTriggerEvent triggerEvent)  {
		//Debug.Log (triggerEvent.tag);

		if (triggerEvent.tag == "Spear" && triggerEvent.triggerType == ColliderTriggerEvent.TRIGGER_TYPE.Enter) {
			//Debug.Log (triggerEvent.tag + " other collider is " + triggerEvent.otherCollider.gameObject.name);

			if (triggerEvent.otherCollider.GetComponent<AnimationBoneCollider>().BoneColliderTag == "Player") {
				Debug.Log (triggerEvent.tag);
				//
				//  stop player
				//
				movement.setSpeed (0f);

				//
				//  spawn particle
				//

				//
				//  Destroy player
				//
				Destroy (triggerEvent.otherCollider.transform.root.gameObject);
			}

		}
	}
}
