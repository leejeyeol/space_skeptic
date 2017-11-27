using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	int speed = 10; 
	float movepower = 8f;
	float jumppower = 16f;
	Rigidbody2D rigid;

	Vector3 movement;
	bool isJumping = false;

	void ControllerCheck()
	{

		bool xbox_a = Input.GetButton("XboxA");
		bool xbox_b = Input.GetButton("XboxB");
		bool xbox_x = Input.GetButton("XboxX");
		bool xbox_y = Input.GetButton("XboxY");


		//string debu = string.Format ("h:{0} , v:{1}", hAxis, vAxis);
		//print (debu);
	

		Move ();
		if (xbox_a) {
			Jump();
		}
		if (xbox_x) {
			print ("attack 1");
		}		
		if (xbox_b) {
			print ("attack 2");
		}		
		if (xbox_y) {
			print ("tools");
		}

	}


	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		ControllerCheck ();
	}

	void Move()
	{
		Vector3 moveVelocity = Vector3.zero;
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");
		if (hAxis <= -0.5f) {
			moveVelocity = Vector3.left;
		}
		else if (vAxis <= -0.5f) {
			moveVelocity = Vector3.up;
		}
		else if (hAxis >= 0.5f) {
			moveVelocity = Vector3.right;
		}
		else if (vAxis >= 0.5f) {
			moveVelocity = Vector3.down;
		}

		transform.position += moveVelocity * movepower * Time.deltaTime;
	}
	void Jump()
	{
		//ADD collision 2d.


		//if (!isJumping)
		//	return;

		rigid.velocity = Vector2.zero;
		Vector2 jumpVelocity = new Vector2 (0, jumppower);
		rigid.AddForce (jumpVelocity, ForceMode2D.Impulse);
		isJumping = false;

	}
		
}
