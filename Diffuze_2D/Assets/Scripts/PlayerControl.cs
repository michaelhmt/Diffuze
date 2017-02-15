using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour {

	Rigidbody2D bBody;

	public float minimum_jump_limt = 0.1f; 
	public float moveforce = 5;
	public float jumpPower = 550;
	public bool jumping;  
	bool IsGrounded = true;
	private float InVertedJumpLimt = -0.1f; 
	private float jumpcache = 0.1f;


	// Use this for initialization
	void Start () {
		bBody = this.GetComponent<Rigidbody2D> ();  //finds the rigidbody of connected object
		jumping = false;   //player is not jumping at start 

		jumpcache = minimum_jump_limt * 2; 
		InVertedJumpLimt = minimum_jump_limt - jumpcache;  // finds the negative inversion of the jump limt 

		
	}
	void FixedUpdate () {
	
		Vector2 movevec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical")) * moveforce;  //adds force based on input from the UI joystick
		bBody.AddForce (movevec);     //adds that force to rigidbody2D

		if (CrossPlatformInputManager.GetButtonUp ("JUMP")) { //if jump button is active fot this update do...
			jump ();
		}

	
		if (bBody.velocity.y < InVertedJumpLimt) {   //check to see if player is falling faster than jump limt 
				IsGrounded = false;
				jumping = true;
			}
		if (bBody.velocity.y > minimum_jump_limt) {   //check to see if player is going up faster than jump limt 
			jumping = true; 
		}
	}


	void jump(){

		if (IsGrounded == true & jumping == false) {               //make sure the player is both not going up or down 
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, jumpPower);   //adds force of jump power to rigid body
			Debug.Log ("Jump"); //print to log so I know its working cause I most likely wrote it wrong 
		}

	}



}
