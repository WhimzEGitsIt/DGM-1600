using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDamage : MonoBehaviour {


	void OnCollisionEnter2D (Collision2D collision) {
		var hit = collision.gameObject;
		var health = hit.GetComponent<BlockHealth> ();
		if (health != null) 
		{
			health.TakeDamage (1);
		}

		Destroy (gameObject);
	}

}
