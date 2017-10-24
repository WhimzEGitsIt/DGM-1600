using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour {

	public int health;
	public Sprite[] picture;
	private int count = 0;

	void OnCollisionEnter2D (Collision2D collider) {
		health--;
		count++;


		if (health <= 0) {
			Destroy (this.gameObject);
		}
		GetComponent<SpriteRenderer> ().sprite = picture [count];
	}

	

}
