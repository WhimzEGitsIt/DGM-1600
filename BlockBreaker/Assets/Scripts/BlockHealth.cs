using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour {

	public int health;

	void OnCollisionEnter2D (Collision2D collider) {
		health--;

		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
	

}
