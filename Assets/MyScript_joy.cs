using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MyScript_joy : MonoBehaviour {

	public FixedJoystick MoveJoystick;
	public FixedTouch TouchField;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var fps= GetComponent<RigidbodyFirstPersonController>();
		
		fps.RunAxis=MoveJoystick.inputVector;
		fps.mouseLook.LookAxis=TouchField.TouchDist;
	}
}
