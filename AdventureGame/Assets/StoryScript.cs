using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject; 

	public enum States {start, chest, bed, campfire, tent_wall, kill_looter, sneak_1, campfire_1, loot_looter, campfire_exit, frozen_wasteland};
	public States myState; 

	public bool knife = false;
	public bool rope = false;
	public bool mask = false;
	public bool blanket = false;
	public bool note = false;

	void Start () {
		myState = States.start;

	}

	void Reset () {
		knife = false;
		rope = false;
		mask = false;
		blanket = false;

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
		} else if (myState == States.campfire_1) {
			State_campfire_1 ();
		} else if (myState == States.bed) {
			State_bed ();
		} else if (myState == States.tent_wall) {
			State_tent_wall ();
		} else if (myState == States.frozen_wasteland) {
			State_frozen_wasteland ();
		} else if (myState == States.sneak_1) {
			State_sneak_1 ();
		} else if (myState == States.loot_looter) {
			State_loot_looter ();
		}

	

	}

	void State_start() {
		textObject.text = "You just took a massive poop in your tent, when all the sudden your camp is raided by rival gang members. " +
		"\nThere is a tent Door leading out to the camp." +
		"\nThere is a Chest in your tent. " +
		"\nThere is a Bed on ground." +
		"\nThere is a back tent Wall." +
		"\n\nPress D to go out the door. Press C to search Chest. Press B to search Bed. Press W to examine the Wall. ";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.campfire;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.chest;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bed;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.tent_wall;
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
		if (mask == true && rope == true && knife == true) {
			textObject.text = "Chest contents:" +
			"\nThe chest is empty" +
			"\n\nYou have taken the hunting knife. You have taken the rope. You have taken the mask. To leave chest, press S.";
		} else if (rope == true && knife == false && mask == false) {
			textObject.text = "Chest contents:" +
			"\nA hunting knife." +
			"\nA mask." +
			"\n\nTo take the knife, press K. You have taken the rope. To take the mask, press M. To leave chest, press S.";
		} else if (knife == true && rope == false && mask == false) {
			textObject.text = "Chest contents:" +
			"\nA rope." +
			"\nA mask." +
			"\n\nYou have taken the hunting knife. To take the rope, press R. To take the mask, press M. To leave chest, press S.";
		} else if (mask == true && rope == false && knife == false) {
			textObject.text = "Chest contents:" +
			"\nA hunting knife." +
			"\nA rope." +
			"\n\nTo take the knife, press K. To take the rope, press R. You have taken the mask. To leave the chest, Press S.";
		} else if (knife == true && rope == true && mask == false) {
			textObject.text = "Chest contents:" +
			"\nA mask." +
			"\n\nYou have taken the hunting knife. You have taken the rope. To take the mask, press M. To leave chest, press S.";
		} else if (knife == false && rope == true && mask == true) {
			textObject.text = "Chest contents:" +
			"\nA hunting knife." +
			"\n\nTo take the knife, press K. You have taken the rope. You have taken the mask. To leave the chest, Press S.";
		} else if (knife == true && rope == false && mask == true) {
			textObject.text = "Chest contents:" +
				"\nA rope." +
				"\n\nYou have taken the hunting knife. To take the rope, press R. You have taken the mask. To leave the chest, Press S.";
		} else if (mask == false && rope == false && knife == false) { 
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
	void State_bed () {
		if (blanket == true) {
			textObject.text = "A straw bed, with a blanket for warmth." +
			"\nYou have taken the blanket." +
			"\n\nTo exit, press E.";
		} else {
			textObject.text = "A straw bed, with a blanket for warmth." +
			"\nTo take the blanket, press B." +
			"\n\nTo exit, press E.";
		} if (Input.GetKeyDown (KeyCode.B)) {
			blanket = true;
		} if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.start;
		}

	}

	void State_tent_wall () {
		if (knife == true) {
			textObject.text = "The back wall of your tent." +
			"\n\nTo use your knife to cut the wall press C." +
			"\nTo go back, press B.";
		} else {
			textObject.text = "The back wall of your tent." +
				"\nPerhaps something sharp could cut a hole in the material." +
				"\n\nTo go back, press B.";
		} if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.frozen_wasteland;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.start;
		}
	}

	void State_frozen_wasteland () {
		if (blanket == true) {
			textObject.text = "You cut a hole in the tent and escape out the back. Running away from your camp you encounter a frozen wasteland." +
			"\nYour blanket keeps you warm for a while, but as you freeze slowly you regret not avenging your clanmates." +
			"\n\nYou have died." +
			"\nPress S to start over.";
		} else {
			textObject.text = "You cut a hole in the tent and escape out the back. Running away from your camp you encounter a frozen wasteland." +
			"\nYou are unprepared for the harsh environment, and freeze to death." +
			"\n\nPress S to start over.";
		} if (Input.GetKeyDown (KeyCode.S)) {
			Reset ();
		}
	}


	void State_kill_looter (){
		if (knife == true) {
			textObject.text = "You slowly approach the man, and draw your knife. Quickly stepping forward, you slice his neck and let his body fall to the ground." +
			"\nYou avenged your fallen clanmates and have won the game!" +
			"\n\nIf you wish to continue the game, press C.";
		} else {
			textObject.text = "As you approach the man, you realize you forgot your weapon and he turns on you. Before you know it, he has drawn his sword and stabbed you through the heart." +
			"\n\nYou have died." +
			"\n\nPress S to start over.";
		}
			if (Input.GetKeyDown (KeyCode.S)) {
			Reset ();
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.campfire_1;
			}
		}

	void State_sneak_1 () {
		textObject.text = "Walking as quiet as you can, you attempt to sneak away from the looter, but accidently snap a twig." +
		"\nThe looter whips around, drawing his sword in the same motion and guts you like a fish." +
		"\nYou have died." +
		"\n\nPress S to start over.";
		if (Input.GetKeyDown (KeyCode.S)) {
			Reset ();
		}
	}
		
	void State_campfire_1 () {
		if (note == true) {
			textObject.text = "A campfire sits in front of you. Your clan mates are dead on the ground, the looter you killed lay at your feet." +
				"\n\nYou have searched the looter." +
				"\nTo leave the camp, press L";
		} else {
			textObject.text = "A campfire sits in front of you. Your clan mates are dead on the ground, the looter you killed lay at your feet." +
			"\n\nTo search looter, press S" +
			"\nTo leave the camp, press L";
		} if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.loot_looter;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.campfire_exit;
		}
	}

	void State_loot_looter () {
		if (note == true) {
			textObject.text = "You have taken the note from the body." +
			"\nIt reads: " +
			"\nUu'ghar, after you and your group of men kill and raid the camp, meet back at the Black Skeleton Fortress. It is about a days ride south of their current camp." +
			"\n\nTo continue, press C.";
		} else {
			textObject.text = "You crouch down and check the body, and find a note." +
				"\nTo take and read the note, press R." +
				"\n\nTo go back, press B.";
		} if (Input.GetKeyDown (KeyCode.R)) {
			note = true;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.campfire_1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.campfire_1;
		}
	}

}