﻿using UnityEngine;
using System.Collections;
using InControl;

public class UserControl : MonoBehaviour {

	PlayerCharacter pChar;

	float horizontal = 0.0f;
	bool jump = false;


	// Use this for initialization
	void Awake () {//There are no Update before Awake
		pChar = GetComponent<PlayerCharacter> ();

	}
	void Start() {//There can be Update before Start
	}
	
	// Update is called once per frame
	void Update () {


		jump = Input.GetKeyDown (KeyCode.Space);//Hardcoded, unable to change the button
		jump = Input.GetButtonDown("Jump");
		//GetButtonDown, true when clik on button
		//GetButton, true if pressed
		//GetButtonUp, true when release button

		horizontal = Input.GetAxis ("Horizontal");

		if (InputManager.Devices.Count > 0) {
			var inputDevice = InputManager.Devices [0];
			horizontal += inputDevice.LeftStickX;
		}

		if (Mathf.Abs(horizontal) > 1.0f) //capping horizontal
		{
			horizontal = Mathf.Sign(horizontal);
		}



		pChar.Move (horizontal, jump);
	}
}
