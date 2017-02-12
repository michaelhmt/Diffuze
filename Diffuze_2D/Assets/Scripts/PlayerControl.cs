using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour {

	Rigidbody2D bBody;
	public float moveforce = 5;
	public float jumpPower = 550;
	private bool jumping;  

	// Use this for initialization
	void Start () {
		bBody = this.GetComponent<Rigidbody2D> ();
		jumping = false;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Vector2 movevec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical")) * moveforce; 
		bBody.AddForce (movevec);
		if (CrossPlatformInputManager.GetButton ("JUMP")) {
			jump ();

		}

	}


	void jump(){


		bBody.AddForce(new Vector2(0,450));
		Debug.Log ("Jump");

	}


}
