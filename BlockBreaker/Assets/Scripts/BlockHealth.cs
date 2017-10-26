using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour {

	public int health;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager levelManager;


	void Start (){
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D collider) {
		health--;
		count++;


		if (health <= 0) {
			LevelManager.brickCount--;
			levelManager.CheckBrickCount ();
			Destroy (this.gameObject);
		}
		GetComponent<SpriteRenderer> ().sprite = picture [count];
	}

	

}
