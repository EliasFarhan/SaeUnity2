﻿using UnityEngine;
using System.Collections;
using InControl;

namespace SaeUnity
{
	public class UserControl : MonoBehaviour {

		PlayerCharacter pChar;

		float horizontal = 0.0f;
		bool jump = false;
		bool fire = false;
		Vector2 fireDir;


		// Use this for initialization
		void Awake () {//There are no Update before Awake
			pChar = GetComponent<PlayerCharacter> ();

		}
		void Start() {//There can be Update before Start
		}
		
		// Update is called once per frame
		void Update () {


			//jump = Input.GetKeyDown (KeyCode.Space);//Hardcoded, unable to change the button
			jump = jump || Input.GetButtonDown("Jump");
			//GetButtonDown, true when clik on button
			//GetButton, true if pressed
			//GetButtonUp, true when release button
			if (Input.GetMouseButtonDown (0)) {
				fire = true;
				fireDir = (Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position);
				fireDir.Normalize ();
			}

			horizontal = Input.GetAxis ("Horizontal");

			if (InputManager.Devices.Count > 0) {
				var inputDevice = InputManager.Devices [0];
				horizontal += inputDevice.LeftStickX;
				jump = inputDevice.Action1.WasPressed || jump;
				if (inputDevice.RightTrigger.WasPressed) {
					fire = true;
					fireDir = new Vector2 (inputDevice.RightStickX, inputDevice.RightStickY).normalized;
				}
			}

			if (Mathf.Abs(horizontal) > 1.0f) //capping horizontal
			{
				horizontal = Mathf.Sign(horizontal);
			}



			
		}
		void FixedUpdate()
		{
			pChar.Move (horizontal, jump);//in Fixed UPDATE because we are doing Physics operations
			jump = false;

			if (fire) {
				pChar.Fire (fireDir);
				fire = false;
			}
		}
	}
}