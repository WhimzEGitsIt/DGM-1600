using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject; 

	public enum States {start, chest, bed, campfire, tent_wall };
	public States myState; 


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
		textObject.text = "Campfire State";
	}


	void State_chest (){
		textObject.text = "Chest State";
	}
}
