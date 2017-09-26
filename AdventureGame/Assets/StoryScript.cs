using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject; 

	public enum States {start, chest, bed, campfire, tent_wall };
	public States myState; 

	public bool knife = false;
	public bool rope = false;
	public bool mask = false;

	void Start () {
		myState = States.start;

	}

	void Update () {
		if (myState == States.start) {
			State_start ();
		} else if (myState == States.campfire) {
			State_campfire ();
		} else if (myState == States.chest) {
			State_chest ();
		}

	}

	void State_start(){
		textObject.text = "You just took a massive poop in your tent, when all the sudden your camp is raided by rival gang members. " +
		"\nThere is a tent Door leading out to the camp." +
		"\nThere is a Chest in your tent. " +
		"\nThere is a Bed on ground." +
		"\nThere is a back tent Wall." +
		"\n\nPress D to go out the door. Press C to search Chest. Press B to search Bed. Press W to examine the Wall. ";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.campfire;
		} else if (Input.GetKeyDown (KeyCode.C)){
			myState = States.chest;
		} 

	}

	void State_campfire (){
		textObject.text = "As you step out of your tent, a campfire sits in front of you. Your clan mates are dead on the ground." +
			"\nTo your east is your clan leaders tent, the door has been ripped off." +
			"\nTo your north is a hostile area" +
			"\nTo your south you see the rival gang riding away in the distant" +
			"\n\nPress E to go east. Press N to go north. Press S to go south.";
	}


	void State_chest (){
		if (knife == true) {
			textObject.text = "Chest contents:" +
				"\nA rope." +
				"\nA mask." +
				"\n\nYou have taken the hunting knife. To take the rope, press R. To take the mask, press M. To leave chest, press S.";
		} else { 
			textObject.text = "Chest contents:" +
			"\nA hunting knife." +
			"\nA rope." +
			"\nA mask." +
			"\n\n To take the knife, press K. To take the rope, press R. To take the mask, press M. To leave chest, press S.";
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			knife = true;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			rope = true;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			mask = true;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}

}

}