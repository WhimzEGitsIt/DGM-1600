using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject; 

	public enum States {start, chest, bed, campfire, tent_wall, kill_looter, sneak_1 };
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
		} else if (myState == States.kill_looter) {
			State_kill_looter ();
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
			textObject.text = "As you step out of your tent, a campfire sits in front of you. Your clan mates are dead on the ground, one of their bodies is being looted by a man." +
				"\n\nTo kill the looter, press K." +
				"\nTo sneak around him, press S.";
		if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.kill_looter;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sneak_1;
		}
	}

	void State_chest (){
		if (mask == true) {
			textObject.text = "Chest contents:" +
				"\nThe chest is empty" +
				"\n\nYou have taken the hunting knife. You have taken the rope. You have taken the mask. To leave chest, press S.";
		} else if (rope == true) {
			textObject.text = "Chest contents:" +
				"\nA mask." +
				"\n\nYou have taken the hunting knife. You have taken the rope. To take the mask, press M. To leave chest, press S.";
		} else if (knife == true) {
			textObject.text = "Chest contents:" +
				"\nA rope." +
				"\nA mask." +
				"\n\nYou have taken the hunting knife. To take the rope, press R. To take the mask, press M. To leave chest, press S.";
		} else { 
			textObject.text = "Chest contents:" +
			"\nA hunting knife." +
			"\nA rope." +
			"\nA mask." +
			"\n\nTo take the knife, press K. To take the rope, press R. To take the mask, press M. To leave chest, press S.";
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
	void State_kill_looter (){
		if (knife == true) {
			textObject.text = "You slowly approach the man, and draw your knife. Quickly stepping forward, you slice his neck and let his body fall to the ground.";
		} else {
			textObject.text = "As you approach the man, you realize you forgot your weapon and he turns on you. Before you know it, he has drawn his sword and stabbed you through the heart." +
				"\n\nYou have died." +
				"\n\nPress S to start over.";
			if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.start;
			}
		}
	}
		


}