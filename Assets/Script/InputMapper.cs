using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputMapper : MonoBehaviour {

	void ControllerCheck()
	{

		bool xbox_a = Input.GetButton("XboxA");
		bool xbox_b = Input.GetButton("XboxB");
		bool xbox_x = Input.GetButton("XboxX");
		bool xbox_y = Input.GetButton("XboxY");
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		//string debu = string.Format ("h:{0} , v:{1}", hAxis, vAxis);
		//print (debu);

		if (hAxis <= -0.5f) {
			print("좌");
		}
		else if (vAxis <= -0.5f) {
			print ("상");
		}
		else if (hAxis >= 0.5f) {
			print ("우");
		}
		else if (vAxis >= 0.5f) {
			print ("하");
		}

	}

	void Update()
	{
		// Camera Rig Movement Control



		ControllerCheck();
	
			
    }
}


