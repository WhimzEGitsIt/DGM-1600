using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessing : MonoBehaviour {

	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;

	// Use this for initialization
	void Start () 
	{
		guess = Random.Range (min,max);




		textBox.text = "Welcome to Number Guesser"
					+ "\n Pick a number in your head"
					+ "\n\n The highest number you can pick is " + max
					+ "\nThe lowest number you can pick is " + min
					+ "\n\nIs the number higher or lower than " + guess
					+ "\n Up arrow for higher, Down arrow for lower, Enter for equal";






		print ("Welcome to Number Guesser");
		print ("Pick a number in your head");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min); 

		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, Down for lower, Enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame


	void Update () 
	{

		if (counter == -1) {
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				//counter--;
				textBox.text = "You win!";
			}

		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			textBox.text = "Is the number higher or lower than " + guess
				+ "\n Up arrow for higher, Down arrow for lower, Enter for equal";
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			textBox.text = "Is the number higher or lower than " + guess
				+ "\n Up arrow for higher, Down arrow for lower, Enter for equal";
		}
		if (Input.GetKeyDown (KeyCode.Return))
		{
			textBox.text = ("I win");
		}

		if (counter == 0) 
		{
			counter--;
		}
	}
}	